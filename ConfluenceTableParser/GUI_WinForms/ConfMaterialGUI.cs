﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
                MessageBox.Show("Не удалось загрузить данные из Confluence. \n" +
                    "Проверьте интернет-соединение и попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string filepath = @"G:\BIM\SHARED\02_REVIT\04_Плагины\Настройки\Проверить модель\3_206_Проверить материалы";
            string filename = @"\3_206_Проверить материалы.json";
            string fullPath = filepath + filename;

            if (materialStorage != null && materialStorage.Count() != 0)
            {
                var data = JsonSerializer.Serialize(materialStorage, options);

                if (!File.Exists(fullPath))
                {
                    try
                    {
                        File.WriteAllText(fullPath, data.ToString());
                        MessageBox.Show("Данные успешно сохранены в .json файл.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    var dialogResult = MessageBox.Show("Файл .json уже существует. Вы уверены, что хотите заменить его?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllText(fullPath, data.ToString());
                        MessageBox.Show("Данные успешно сохранены в .json файл.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }

            }
            else
            {
                MessageBox.Show("Список материалов пуст. \n" +
                    "Перед экспортом необходимо сначала загрузить данные в приложение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            //Encoder = JavaScriptEncoder.Create(GetEncoderSettings()),
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        private static TextEncoderSettings GetEncoderSettings()
        {
            var encoder = new TextEncoderSettings();
            //encoder.AllowCharacters('\u00A0');
            encoder.ForbidCharacters('\u00A0');
            encoder.AllowRanges(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
            return encoder;
        }
    }
}
