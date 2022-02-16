using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;

namespace KDZCardGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _headers = new();
        }
        private readonly List<string> _headers;
        private string _imagePath;
        private void OpenFileDialogbtn_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                Debug.WriteLine(filename);
                var fileStream = openFileDialog.OpenFile();
                using var readerStream = new StreamReader(fileStream);
                var workbook = new XSSFWorkbook(fileStream);
                var sheet = workbook.GetSheetAt(0);
                _readHeaderTitle(sheet.GetRow(0));
                for (var i = sheet.FirstRowNum + 1; i < sheet.LastRowNum; i++)
                {
                    var row = sheet.GetRow(i);
                    if (row == null) continue;
                    if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                    Exceldgv.Rows.Add(row.Cells.Select(c => c.ToString()).ToArray());
                }
            }
        }

        private void _readHeaderTitle(IRow row)
        {
            if (row is null)
            {
                MessageBox.Show("Excel error!", "Please check it", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            _headers.Clear();
            _headers.AddRange(row.Cells.Select(c => c?.ToString()).ToArray());
            Exceldgv.Columns.Clear();
            Exceldgv.Columns.AddRange(row.Cells.Select(c => new DataGridViewTextBoxColumn()
            {
                HeaderText = c.ToString(),
                Name = c.ToString()
            }).ToArray());
            ImageColCmb.Items.Clear();
            ImageColCmb.Items.AddRange(row.Cells.Select(c => c.ToString()).ToArray());
        }

        private void SelectFolderbtn_Click(object sender, EventArgs e)
        {
            using var dialogFolder = new FolderBrowserDialog();
            if (dialogFolder.ShowDialog() == DialogResult.OK)
            {
                _imagePath = dialogFolder.SelectedPath;
                CheckImagebtn.Enabled = true;
            }
        }

        private void SelectReportFileBtn_Click(object sender, EventArgs e)
        {
            using var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Json (*.json)|*.json";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var testobj = new List<Dictionary<string, string>>();
                foreach (DataGridViewRow row in Exceldgv.Rows)
                {
                    if (row.Cells[0].Value is null)
                        continue;
                    var properteis = new Dictionary<string, string>();

                    for (int i = 0; i < _headers.Count; i++)
                    {
                        if (i == ImageColCmb.SelectedIndex)
                        {
                            if (!File.Exists(Path.Combine(_imagePath, row.Cells[ImageColCmb.SelectedIndex].Value.ToString())))
                            {
                                MessageBox.Show($"Row {row.Index + 1} need review.", "Check your images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            properteis.Add(_headers[i], Path.Combine(_imagePath, row.Cells[ImageColCmb.SelectedIndex].Value.ToString()??""));
                            continue;
                        }
                        properteis.Add(_headers[i], row.Cells[i].Value.ToString() ?? "");
                    }

                    testobj.Add(properteis);
                }
                JsonSerializerOptions jso = new JsonSerializerOptions();
                jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                File.WriteAllText(fileDialog.FileName, JsonSerializer.Serialize(testobj, jso));
            }
        }

        private void CheckImagebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Exceldgv.Rows)
            {
                if (row.Cells[ImageColCmb.SelectedIndex].Value is null)
                    continue;

                if (!File.Exists(Path.Combine(_imagePath, row.Cells[ImageColCmb.SelectedIndex].Value.ToString())))
                {
                    MessageBox.Show($"Row {row.Index + 1} need review.", "Check your images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}