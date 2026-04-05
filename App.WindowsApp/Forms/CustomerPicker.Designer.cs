namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerpicker = new TableLayoutPanel();
            flpSearchbar = new FlowLayoutPanel();
            lblSearchText = new Label();
            txtSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lsCustomers = new ListBox();
            tlpCustomerpicker.SuspendLayout();
            flpSearchbar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerpicker
            // 
            tlpCustomerpicker.BackColor = Color.White;
            tlpCustomerpicker.ColumnCount = 1;
            tlpCustomerpicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerpicker.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCustomerpicker.Controls.Add(flpSearchbar, 0, 0);
            tlpCustomerpicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerpicker.Controls.Add(lsCustomers, 0, 1);
            tlpCustomerpicker.Dock = DockStyle.Fill;
            tlpCustomerpicker.Location = new Point(0, 0);
            tlpCustomerpicker.Name = "tlpCustomerpicker";
            tlpCustomerpicker.RowCount = 3;
            tlpCustomerpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 76.44444F));
            tlpCustomerpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5555553F));
            tlpCustomerpicker.Size = new Size(800, 450);
            tlpCustomerpicker.TabIndex = 0;
            // 
            // flpSearchbar
            // 
            flpSearchbar.Controls.Add(lblSearchText);
            flpSearchbar.Controls.Add(txtSearchQuery);
            flpSearchbar.Dock = DockStyle.Fill;
            flpSearchbar.Location = new Point(3, 3);
            flpSearchbar.Name = "flpSearchbar";
            flpSearchbar.Size = new Size(794, 39);
            flpSearchbar.TabIndex = 0;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchText.Location = new Point(3, 0);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(112, 23);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search Query";
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(121, 3);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(493, 27);
            txtSearchQuery.TabIndex = 1;
            txtSearchQuery.TextChanged += txtSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 392);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(794, 55);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.White;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Image = Properties.Resources.Add;
            btnSelect.Location = new Point(679, 9);
            btnSelect.Margin = new Padding(9);
            btnSelect.Name = "btnSelect";
            btnSelect.Padding = new Padding(3);
            btnSelect.Size = new Size(106, 49);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel1;
            btnCancel.Location = new Point(557, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(104, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsCustomers
            // 
            lsCustomers.Dock = DockStyle.Fill;
            lsCustomers.FormattingEnabled = true;
            lsCustomers.Location = new Point(3, 48);
            lsCustomers.Name = "lsCustomers";
            lsCustomers.Size = new Size(794, 338);
            lsCustomers.TabIndex = 2;
            lsCustomers.DoubleClick += lsCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpCustomerpicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerpicker.ResumeLayout(false);
            flpSearchbar.ResumeLayout(false);
            flpSearchbar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerpicker;
        private FlowLayoutPanel flpSearchbar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchText;
        private TextBox txtSearchQuery;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lsCustomers;
    }
}