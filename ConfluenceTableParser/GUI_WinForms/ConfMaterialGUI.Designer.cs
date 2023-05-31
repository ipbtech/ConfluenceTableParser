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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNotationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialMeasureUnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialUsageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A list of usage materials from Confluence:";
            // 
            // GetDataButton
            // 
            this.GetDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDataButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GetDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetDataButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetDataButton.Location = new System.Drawing.Point(742, 74);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(110, 30);
            this.GetDataButton.TabIndex = 2;
            this.GetDataButton.Text = "Get Data";
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
            this.JSONExportButton.Location = new System.Drawing.Point(742, 142);
            this.JSONExportButton.Name = "JSONExportButton";
            this.JSONExportButton.Size = new System.Drawing.Size(110, 30);
            this.JSONExportButton.TabIndex = 3;
            this.JSONExportButton.Text = "JSON Export";
            this.JSONExportButton.UseVisualStyleBackColor = false;
            this.JSONExportButton.Click += new System.EventHandler(this.JSONExportButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.MaterialGroupColumn,
            this.MaterialTitleColumn,
            this.MaterialNameColumn,
            this.MaterialNotationColumn,
            this.MaterialMeasureUnitsColumn,
            this.MaterialUsageColumn});
            this.DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridView.Location = new System.Drawing.Point(17, 40);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 20;
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(700, 440);
            this.DataGridView.TabIndex = 4;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 10;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 40;
            // 
            // MaterialGroupColumn
            // 
            this.MaterialGroupColumn.HeaderText = "Group";
            this.MaterialGroupColumn.MinimumWidth = 10;
            this.MaterialGroupColumn.Name = "MaterialGroupColumn";
            this.MaterialGroupColumn.Width = 100;
            // 
            // MaterialTitleColumn
            // 
            this.MaterialTitleColumn.HeaderText = "Title";
            this.MaterialTitleColumn.MinimumWidth = 10;
            this.MaterialTitleColumn.Name = "MaterialTitleColumn";
            this.MaterialTitleColumn.Width = 140;
            // 
            // MaterialNameColumn
            // 
            this.MaterialNameColumn.HeaderText = "Name";
            this.MaterialNameColumn.MinimumWidth = 10;
            this.MaterialNameColumn.Name = "MaterialNameColumn";
            this.MaterialNameColumn.Width = 140;
            // 
            // MaterialNotationColumn
            // 
            this.MaterialNotationColumn.HeaderText = "Notation";
            this.MaterialNotationColumn.MinimumWidth = 10;
            this.MaterialNotationColumn.Name = "MaterialNotationColumn";
            this.MaterialNotationColumn.Width = 140;
            // 
            // MaterialMeasureUnitsColumn
            // 
            this.MaterialMeasureUnitsColumn.HeaderText = "Units";
            this.MaterialMeasureUnitsColumn.MinimumWidth = 10;
            this.MaterialMeasureUnitsColumn.Name = "MaterialMeasureUnitsColumn";
            this.MaterialMeasureUnitsColumn.Width = 40;
            // 
            // MaterialUsageColumn
            // 
            this.MaterialUsageColumn.HeaderText = "Usage";
            this.MaterialUsageColumn.MinimumWidth = 10;
            this.MaterialUsageColumn.Name = "MaterialUsageColumn";
            this.MaterialUsageColumn.Width = 100;
            // 
            // ConfMaterialGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(876, 498);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.JSONExportButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfMaterialGUI";
            this.Text = "ConfluenceUsageMaterialData";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button JSONExportButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNotationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialMeasureUnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialUsageColumn;
    }
}

