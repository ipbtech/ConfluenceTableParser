namespace ConfluenceTableParser
{
    partial class ConfMaterialGUI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfMaterialGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.JSONExportButton = new System.Windows.Forms.Button();
            this.DataGridMaterialView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNotationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialMeasureUnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialUsageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMaterialView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список используемых материалов из Confluence:";
            // 
            // GetDataButton
            // 
            this.GetDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDataButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GetDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetDataButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetDataButton.Location = new System.Drawing.Point(750, 74);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(110, 30);
            this.GetDataButton.TabIndex = 2;
            this.GetDataButton.Text = "Загрузить";
            this.GetDataButton.UseVisualStyleBackColor = false;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // JSONExportButton
            // 
            this.JSONExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONExportButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.JSONExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JSONExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JSONExportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JSONExportButton.Location = new System.Drawing.Point(750, 142);
            this.JSONExportButton.Name = "JSONExportButton";
            this.JSONExportButton.Size = new System.Drawing.Size(110, 30);
            this.JSONExportButton.TabIndex = 3;
            this.JSONExportButton.Text = "Экспорт json";
            this.JSONExportButton.UseVisualStyleBackColor = false;
            this.JSONExportButton.Click += new System.EventHandler(this.JSONExportButton_Click);
            // 
            // DataGridMaterialView
            // 
            this.DataGridMaterialView.AllowUserToAddRows = false;
            this.DataGridMaterialView.AllowUserToDeleteRows = false;
            this.DataGridMaterialView.AllowUserToResizeRows = false;
            this.DataGridMaterialView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridMaterialView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridMaterialView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridMaterialView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridMaterialView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMaterialView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.MaterialGroupColumn,
            this.MaterialTitleColumn,
            this.MaterialNameColumn,
            this.MaterialNotationColumn,
            this.MaterialMeasureUnitsColumn,
            this.MaterialUsageColumn});
            this.DataGridMaterialView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridMaterialView.Location = new System.Drawing.Point(17, 40);
            this.DataGridMaterialView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridMaterialView.Name = "DataGridMaterialView";
            this.DataGridMaterialView.RowHeadersVisible = false;
            this.DataGridMaterialView.RowHeadersWidth = 20;
            this.DataGridMaterialView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridMaterialView.RowTemplate.Height = 33;
            this.DataGridMaterialView.RowTemplate.ReadOnly = true;
            this.DataGridMaterialView.Size = new System.Drawing.Size(708, 503);
            this.DataGridMaterialView.TabIndex = 4;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 10;
            this.IDColumn.Name = "IDColumn";
            // 
            // MaterialGroupColumn
            // 
            this.MaterialGroupColumn.HeaderText = "Группа";
            this.MaterialGroupColumn.MinimumWidth = 10;
            this.MaterialGroupColumn.Name = "MaterialGroupColumn";
            // 
            // MaterialTitleColumn
            // 
            this.MaterialTitleColumn.HeaderText = "Имя материала";
            this.MaterialTitleColumn.MinimumWidth = 10;
            this.MaterialTitleColumn.Name = "MaterialTitleColumn";
            // 
            // MaterialNameColumn
            // 
            this.MaterialNameColumn.HeaderText = "Мтрл.Название";
            this.MaterialNameColumn.MinimumWidth = 10;
            this.MaterialNameColumn.Name = "MaterialNameColumn";
            // 
            // MaterialNotationColumn
            // 
            this.MaterialNotationColumn.HeaderText = "О_Материал обозначение";
            this.MaterialNotationColumn.MinimumWidth = 10;
            this.MaterialNotationColumn.Name = "MaterialNotationColumn";
            // 
            // MaterialMeasureUnitsColumn
            // 
            this.MaterialMeasureUnitsColumn.HeaderText = "О_Единицы измерения";
            this.MaterialMeasureUnitsColumn.MinimumWidth = 10;
            this.MaterialMeasureUnitsColumn.Name = "MaterialMeasureUnitsColumn";
            // 
            // MaterialUsageColumn
            // 
            this.MaterialUsageColumn.HeaderText = "Применение";
            this.MaterialUsageColumn.MinimumWidth = 10;
            this.MaterialUsageColumn.Name = "MaterialUsageColumn";
            // 
            // ConfMaterialGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.DataGridMaterialView);
            this.Controls.Add(this.JSONExportButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ConfMaterialGUI";
            this.Text = "Confluence материалы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMaterialView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button JSONExportButton;
        private System.Windows.Forms.DataGridView DataGridMaterialView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNotationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialMeasureUnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialUsageColumn;
    }
}

