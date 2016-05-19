namespace FiltersApp
{
    partial class PopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.XBox = new System.Windows.Forms.ComboBox();
            this.YBox = new System.Windows.Forms.ComboBox();
            this.TextBoxGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offsetNumeric = new System.Windows.Forms.NumericUpDown();
            this.dividerNumeric = new System.Windows.Forms.NumericUpDown();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.anchorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.anchorXComboBox = new System.Windows.Forms.ComboBox();
            this.anchorYComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.defaultLabel = new System.Windows.Forms.Label();
            this.defaultValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.predefinedFiltersComboBox = new System.Windows.Forms.ComboBox();
            this.predefinedFiltersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(0, 358);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(254, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(0, 335);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(254, 23);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.acceptButton_click);
            // 
            // XBox
            // 
            this.XBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XBox.Location = new System.Drawing.Point(410, 70);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(112, 21);
            this.XBox.Sorted = true;
            this.XBox.TabIndex = 2;
            this.XBox.SelectedIndexChanged += new System.EventHandler(this.XBox_SelectedIndexChanged);
            // 
            // YBox
            // 
            this.YBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YBox.FormattingEnabled = true;
            this.YBox.Location = new System.Drawing.Point(410, 97);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(112, 21);
            this.YBox.TabIndex = 3;
            this.YBox.SelectedIndexChanged += new System.EventHandler(this.YBox_SelectedIndexChanged);
            // 
            // TextBoxGrid
            // 
            this.TextBoxGrid.AllowUserToAddRows = false;
            this.TextBoxGrid.AllowUserToDeleteRows = false;
            this.TextBoxGrid.AllowUserToResizeColumns = false;
            this.TextBoxGrid.AllowUserToResizeRows = false;
            this.TextBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TextBoxGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TextBoxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TextBoxGrid.ColumnHeadersVisible = false;
            this.TextBoxGrid.Location = new System.Drawing.Point(12, 12);
            this.TextBoxGrid.MultiSelect = false;
            this.TextBoxGrid.Name = "TextBoxGrid";
            this.TextBoxGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TextBoxGrid.RowHeadersVisible = false;
            this.TextBoxGrid.RowHeadersWidth = 11;
            this.TextBoxGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TextBoxGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TextBoxGrid.ShowCellErrors = false;
            this.TextBoxGrid.ShowCellToolTips = false;
            this.TextBoxGrid.ShowEditingIcon = false;
            this.TextBoxGrid.ShowRowErrors = false;
            this.TextBoxGrid.Size = new System.Drawing.Size(369, 317);
            this.TextBoxGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // offsetNumeric
            // 
            this.offsetNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetNumeric.Location = new System.Drawing.Point(425, 137);
            this.offsetNumeric.Name = "offsetNumeric";
            this.offsetNumeric.Size = new System.Drawing.Size(97, 20);
            this.offsetNumeric.TabIndex = 7;
            // 
            // dividerNumeric
            // 
            this.dividerNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerNumeric.Location = new System.Drawing.Point(425, 176);
            this.dividerNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dividerNumeric.Name = "dividerNumeric";
            this.dividerNumeric.Size = new System.Drawing.Size(97, 20);
            this.dividerNumeric.TabIndex = 8;
            this.dividerNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // offsetLabel
            // 
            this.offsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(412, 121);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(35, 13);
            this.offsetLabel.TabIndex = 9;
            this.offsetLabel.Text = "Offset";
            // 
            // dividerLabel
            // 
            this.dividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(407, 160);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(40, 13);
            this.dividerLabel.TabIndex = 10;
            this.dividerLabel.Text = "Divider";
            // 
            // anchorLabel
            // 
            this.anchorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorLabel.AutoSize = true;
            this.anchorLabel.Location = new System.Drawing.Point(387, 239);
            this.anchorLabel.Name = "anchorLabel";
            this.anchorLabel.Size = new System.Drawing.Size(41, 13);
            this.anchorLabel.TabIndex = 11;
            this.anchorLabel.Text = "Anchor";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y:";
            // 
            // anchorXComboBox
            // 
            this.anchorXComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anchorXComboBox.FormattingEnabled = true;
            this.anchorXComboBox.Location = new System.Drawing.Point(425, 255);
            this.anchorXComboBox.Name = "anchorXComboBox";
            this.anchorXComboBox.Size = new System.Drawing.Size(97, 21);
            this.anchorXComboBox.TabIndex = 14;
            // 
            // anchorYComboBox
            // 
            this.anchorYComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anchorYComboBox.FormattingEnabled = true;
            this.anchorYComboBox.Location = new System.Drawing.Point(425, 285);
            this.anchorYComboBox.Name = "anchorYComboBox";
            this.anchorYComboBox.Size = new System.Drawing.Size(97, 21);
            this.anchorYComboBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(344, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save filter";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_click);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTextBox.Location = new System.Drawing.Point(425, 337);
            this.saveTextBox.MaxLength = 20;
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(100, 20);
            this.saveTextBox.TabIndex = 17;
            // 
            // defaultLabel
            // 
            this.defaultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultLabel.AutoSize = true;
            this.defaultLabel.Location = new System.Drawing.Point(402, 199);
            this.defaultLabel.Name = "defaultLabel";
            this.defaultLabel.Size = new System.Drawing.Size(70, 13);
            this.defaultLabel.TabIndex = 18;
            this.defaultLabel.Text = "Default value";
            // 
            // defaultValueNumeric
            // 
            this.defaultValueNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValueNumeric.Location = new System.Drawing.Point(425, 218);
            this.defaultValueNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.defaultValueNumeric.Name = "defaultValueNumeric";
            this.defaultValueNumeric.Size = new System.Drawing.Size(97, 20);
            this.defaultValueNumeric.TabIndex = 19;
            // 
            // predefinedFiltersComboBox
            // 
            this.predefinedFiltersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.predefinedFiltersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.predefinedFiltersComboBox.FormattingEnabled = true;
            this.predefinedFiltersComboBox.Location = new System.Drawing.Point(401, 43);
            this.predefinedFiltersComboBox.Name = "predefinedFiltersComboBox";
            this.predefinedFiltersComboBox.Size = new System.Drawing.Size(121, 21);
            this.predefinedFiltersComboBox.TabIndex = 20;
            this.predefinedFiltersComboBox.SelectedIndexChanged += new System.EventHandler(this.LoadPredefinedFilterToMatrix);
            // 
            // predefinedFiltersLabel
            // 
            this.predefinedFiltersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.predefinedFiltersLabel.AutoSize = true;
            this.predefinedFiltersLabel.Location = new System.Drawing.Point(405, 24);
            this.predefinedFiltersLabel.Name = "predefinedFiltersLabel";
            this.predefinedFiltersLabel.Size = new System.Drawing.Size(114, 13);
            this.predefinedFiltersLabel.TabIndex = 21;
            this.predefinedFiltersLabel.Text = "Load predefined matrix";
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.predefinedFiltersLabel);
            this.Controls.Add(this.predefinedFiltersComboBox);
            this.Controls.Add(this.defaultValueNumeric);
            this.Controls.Add(this.defaultLabel);
            this.Controls.Add(this.saveTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.anchorYComboBox);
            this.Controls.Add(this.anchorXComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.anchorLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.dividerNumeric);
            this.Controls.Add(this.offsetNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGrid);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ComboBox XBox;
        private System.Windows.Forms.ComboBox YBox;
        private System.Windows.Forms.DataGridView TextBoxGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown offsetNumeric;
        private System.Windows.Forms.NumericUpDown dividerNumeric;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label anchorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox anchorXComboBox;
        private System.Windows.Forms.ComboBox anchorYComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Label defaultLabel;
        private System.Windows.Forms.NumericUpDown defaultValueNumeric;
        private System.Windows.Forms.ComboBox predefinedFiltersComboBox;
        private System.Windows.Forms.Label predefinedFiltersLabel;
    }
}