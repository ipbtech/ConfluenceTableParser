using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConfluenceTableParser
{
    public partial class ConfMaterialGUI : Form
    {
        public ConfMaterialGUI()
        {
            InitializeComponent();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            UsageMaterialStorage usageMaterials = MyParser.GetDataTable();
            if (usageMaterials.Count() == 0)
            {
                MessageBox.Show("Couldn't get the data \n" +
                    "Check your network connection and try again.");
            }
            else
            {
                int count = 1;
                foreach (UsageMaterial usmt in usageMaterials)
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

        }
    }
}
