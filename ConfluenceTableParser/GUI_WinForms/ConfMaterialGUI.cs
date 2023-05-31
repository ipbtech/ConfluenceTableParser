using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace ConfluenceTableParser
{
    public partial class ConfMaterialGUI : Form
    {
        private UsageMaterialStorage materialStorage;
        public ConfMaterialGUI()
        {
            InitializeComponent();
            materialStorage = null;
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            DataGridMaterialView.Rows.Clear();

            UsageMaterialStorage usageMaterials = MyParser.GetDataTable();
            materialStorage = usageMaterials;
            if (materialStorage.Count() == 0)
            {
                MessageBox.Show("Couldn't get the data \n" +
                    "Check your network connection and try again.");
            }
            else
            {
                int count = 1;
                foreach (UsageMaterial usmt in materialStorage)
                {
                    DataGridMaterialView.Rows.Add();
                    DataGridViewRow row = DataGridMaterialView.Rows[DataGridMaterialView.Rows.GetLastRow(DataGridViewElementStates.None)];
                    row.Height = 21;
                    row.Cells["IDColumn"].Value = count;
                    row.Cells["MaterialGroupColumn"].Value = usmt.MaterialGroup;
                    row.Cells["MaterialTitleColumn"].Value = usmt.MaterialTitle;
                    row.Cells["MaterialNameColumn"].Value = usmt.MaterialName;
                    row.Cells["MaterialNotationColumn"].Value = usmt.MaterialNotation;
                    row.Cells["MaterialMeasureUnitsColumn"].Value = usmt.MaterialMeasureUnits;
                    row.Cells["MaterialUsageColumn"].Value = usmt.MaterialUsage;
                    count++;

                    Color color = Color.Empty;
                    if (count % 2 == 0) { color = Color.AliceBlue; }
                    if (count % 2 != 0) { color = Color.LightGray; }
                    foreach (DataGridViewCell cell in row.Cells) { cell.Style.BackColor = color; }
                }
            }
        }

        private void JSONExportButton_Click(object sender, EventArgs e)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = @"\ConfluenceMaterialData.json";

            if (materialStorage != null)
            {
                StringBuilder data = new StringBuilder();
                foreach (UsageMaterial usmt in materialStorage)
                {
                    data.Append(JsonSerializer.Serialize(usmt, options) + Environment.NewLine);
                }

                File.WriteAllText(filepath + filename, data.ToString());
                MessageBox.Show("Data has been saved to file.");

            }
            else
            {
                MessageBox.Show("Couldn't get the data. List of materials is empty.\n" +
                "Check your network connection and try again.");
            }
        }
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All), // Вот эта строка поможет с кодировкой
            WriteIndented = true
        };
    }
}
