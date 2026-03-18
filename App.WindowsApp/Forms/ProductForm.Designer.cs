namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tlpProductform = new TableLayoutPanel();
            lblNamePF = new Label();
            lblCategoryPF = new Label();
            lblPricePF = new Label();
            lblStockPF = new Label();
            lblStatusPF = new Label();
            lblIDPF = new Label();
            txtIdPf = new TextBox();
            CmbStatus = new ComboBox();
            NudPricePf = new NumericUpDown();
            NudStockPF = new NumericUpDown();
            CmbCategory = new ComboBox();
            txtName = new TextBox();
            flpBottomPF = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpProductform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudPricePf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudStockPF).BeginInit();
            flpBottomPF.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProductform
            // 
            tlpProductform.BackColor = Color.White;
            tlpProductform.ColumnCount = 2;
            tlpProductform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0718594F));
            tlpProductform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.92814F));
            tlpProductform.Controls.Add(lblNamePF, 0, 0);
            tlpProductform.Controls.Add(lblCategoryPF, 0, 1);
            tlpProductform.Controls.Add(lblPricePF, 0, 2);
            tlpProductform.Controls.Add(lblStockPF, 0, 3);
            tlpProductform.Controls.Add(lblStatusPF, 0, 4);
            tlpProductform.Controls.Add(lblIDPF, 0, 5);
            tlpProductform.Controls.Add(txtIdPf, 1, 5);
            tlpProductform.Controls.Add(CmbStatus, 1, 4);
            tlpProductform.Controls.Add(NudPricePf, 1, 2);
            tlpProductform.Controls.Add(NudStockPF, 1, 3);
            tlpProductform.Controls.Add(CmbCategory, 1, 1);
            tlpProductform.Controls.Add(txtName, 1, 0);
            tlpProductform.Dock = DockStyle.Top;
            tlpProductform.Location = new Point(10, 10);
            tlpProductform.Name = "tlpProductform";
            tlpProductform.RowCount = 7;
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2564106F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 9.324009F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 9.55711F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 9.324009F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 10.72261F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 8.857809F));
            tlpProductform.RowStyles.Add(new RowStyle(SizeType.Percent, 43.1235428F));
            tlpProductform.Size = new Size(668, 457);
            tlpProductform.TabIndex = 0;
            // 
            // lblNamePF
            // 
            lblNamePF.AutoSize = true;
            lblNamePF.Dock = DockStyle.Left;
            lblNamePF.Location = new Point(3, 0);
            lblNamePF.Name = "lblNamePF";
            lblNamePF.Size = new Size(49, 46);
            lblNamePF.TabIndex = 6;
            lblNamePF.Text = "Name";
            lblNamePF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategoryPF
            // 
            lblCategoryPF.AutoSize = true;
            lblCategoryPF.Dock = DockStyle.Left;
            lblCategoryPF.Location = new Point(3, 46);
            lblCategoryPF.Name = "lblCategoryPF";
            lblCategoryPF.Size = new Size(69, 42);
            lblCategoryPF.TabIndex = 7;
            lblCategoryPF.Text = "Category";
            lblCategoryPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPricePF
            // 
            lblPricePF.AutoSize = true;
            lblPricePF.Dock = DockStyle.Left;
            lblPricePF.Location = new Point(3, 88);
            lblPricePF.Name = "lblPricePF";
            lblPricePF.Size = new Size(41, 43);
            lblPricePF.TabIndex = 8;
            lblPricePF.Text = "Price";
            lblPricePF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStockPF
            // 
            lblStockPF.AutoSize = true;
            lblStockPF.Dock = DockStyle.Left;
            lblStockPF.Location = new Point(3, 131);
            lblStockPF.Name = "lblStockPF";
            lblStockPF.Size = new Size(45, 42);
            lblStockPF.TabIndex = 9;
            lblStockPF.Text = "Stock";
            lblStockPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusPF
            // 
            lblStatusPF.AutoSize = true;
            lblStatusPF.Dock = DockStyle.Left;
            lblStatusPF.Location = new Point(3, 173);
            lblStatusPF.Name = "lblStatusPF";
            lblStatusPF.Size = new Size(49, 48);
            lblStatusPF.TabIndex = 10;
            lblStatusPF.Text = "Status";
            lblStatusPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIDPF
            // 
            lblIDPF.AutoSize = true;
            lblIDPF.Dock = DockStyle.Left;
            lblIDPF.Location = new Point(3, 221);
            lblIDPF.Name = "lblIDPF";
            lblIDPF.Size = new Size(24, 40);
            lblIDPF.TabIndex = 11;
            lblIDPF.Text = "ID";
            lblIDPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdPf
            // 
            txtIdPf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdPf.Location = new Point(97, 224);
            txtIdPf.Name = "txtIdPf";
            txtIdPf.ReadOnly = true;
            txtIdPf.Size = new Size(568, 27);
            txtIdPf.TabIndex = 5;
            // 
            // CmbStatus
            // 
            CmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CmbStatus.FormattingEnabled = true;
            CmbStatus.Location = new Point(97, 176);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(568, 28);
            CmbStatus.TabIndex = 4;
            // 
            // NudPricePf
            // 
            NudPricePf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NudPricePf.Location = new Point(97, 91);
            NudPricePf.Name = "NudPricePf";
            NudPricePf.Size = new Size(568, 27);
            NudPricePf.TabIndex = 2;
            // 
            // NudStockPF
            // 
            NudStockPF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NudStockPF.Location = new Point(97, 134);
            NudStockPF.Name = "NudStockPF";
            NudStockPF.Size = new Size(568, 27);
            NudStockPF.TabIndex = 3;
            // 
            // CmbCategory
            // 
            CmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CmbCategory.FormattingEnabled = true;
            CmbCategory.Location = new Point(97, 49);
            CmbCategory.Name = "CmbCategory";
            CmbCategory.Size = new Size(568, 28);
            CmbCategory.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(97, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(568, 27);
            txtName.TabIndex = 0;
            // 
            // flpBottomPF
            // 
            flpBottomPF.BackColor = Color.White;
            flpBottomPF.Controls.Add(btnSave);
            flpBottomPF.Controls.Add(btnCancel);
            flpBottomPF.FlowDirection = FlowDirection.RightToLeft;
            flpBottomPF.Location = new Point(0, 473);
            flpBottomPF.Name = "flpBottomPF";
            flpBottomPF.Size = new Size(688, 42);
            flpBottomPF.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Image = Properties.Resources.Add;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(591, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.TopRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Image = Properties.Resources.cancel1;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(491, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 30);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 515);
            Controls.Add(flpBottomPF);
            Controls.Add(tlpProductform);
            MinimizeBox = false;
            Name = "ProductForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tlpProductform.ResumeLayout(false);
            tlpProductform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudPricePf).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudStockPF).EndInit();
            flpBottomPF.ResumeLayout(false);
            flpBottomPF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProductform;
        private Label lblNamePF;
        private Label lblCategoryPF;
        private Label lblPricePF;
        private Label lblStockPF;
        private Label lblStatusPF;
        private Label lblIDPF;
        private TextBox txtIdPf;
        private ComboBox CmbCategory;
        private ComboBox CmbStatus;
        private NumericUpDown NudPricePf;
        private NumericUpDown NudStockPF;
        private FlowLayoutPanel flpBottomPF;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
    }
}