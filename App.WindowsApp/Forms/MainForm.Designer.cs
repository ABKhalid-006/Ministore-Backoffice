namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            picUserIcon = new PictureBox();
            lblUser = new Label();
            flpleft = new FlowLayoutPanel();
            pblogo = new PictureBox();
            lblMiniStore = new Label();
            panelLeft = new Panel();
            flpnav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrder = new Button();
            btnReports = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            pnlContent = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnCustomer = new Button();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).BeginInit();
            flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            panelLeft.SuspendLayout();
            flpnav.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpleft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 9F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 3, 2, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(834, 60);
            pnlHeader.TabIndex = 0;
            //pnlHeader.Paint += panelHeader_Paint;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(picUserIcon);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Font = new Font("Segoe UI", 9F);
            flpRight.Location = new Point(656, 0);
            flpRight.Margin = new Padding(2, 3, 2, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(178, 60);
            flpRight.TabIndex = 1;
            //flpRight.Paint += flpRight_Paint;
            // 
            // picUserIcon
            // 
            picUserIcon.Image = Properties.Resources.account;
            picUserIcon.Location = new Point(2, 3);
            picUserIcon.Margin = new Padding(2, 3, 2, 3);
            picUserIcon.Name = "picUserIcon";
            picUserIcon.Size = new Size(45, 50);
            picUserIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picUserIcon.TabIndex = 1;
            picUserIcon.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(51, 18);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(54, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Admin";
            // 
            // flpleft
            // 
            flpleft.Controls.Add(pblogo);
            flpleft.Controls.Add(lblMiniStore);
            flpleft.Dock = DockStyle.Left;
            flpleft.Font = new Font("Segoe UI", 9F);
            flpleft.Location = new Point(0, 0);
            flpleft.Margin = new Padding(2, 3, 2, 3);
            flpleft.Name = "flpleft";
            flpleft.Size = new Size(178, 60);
            flpleft.TabIndex = 0;
            //flpleft.Paint += flpleft_Paint;
            // 
            // pblogo
            // 
            pblogo.Image = Properties.Resources.museum_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            pblogo.Location = new Point(2, 3);
            pblogo.Margin = new Padding(2, 3, 2, 3);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(45, 50);
            pblogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // lblMiniStore
            // 
            lblMiniStore.Anchor = AnchorStyles.None;
            lblMiniStore.AutoSize = true;
            lblMiniStore.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiniStore.Location = new Point(51, 18);
            lblMiniStore.Margin = new Padding(2, 0, 2, 0);
            lblMiniStore.Name = "lblMiniStore";
            lblMiniStore.Size = new Size(80, 20);
            lblMiniStore.TabIndex = 1;
            lblMiniStore.Text = "Mini Store";
            //lblMiniStore.Click += label1_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(flpnav);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Font = new Font("Segoe UI", 9F);
            panelLeft.Location = new Point(0, 60);
            panelLeft.Margin = new Padding(2, 3, 2, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(178, 573);
            panelLeft.TabIndex = 1;
            //panelLeft.Paint += panelLeft_Paint;
            // 
            // flpnav
            // 
            flpnav.Controls.Add(btnDashboard);
            flpnav.Controls.Add(btnProducts);
            flpnav.Controls.Add(btnCustomer);
            flpnav.Controls.Add(btnOrder);
            flpnav.Controls.Add(btnReports);
            flpnav.Controls.Add(btnSync);
            flpnav.Controls.Add(btnLogs);
            flpnav.Controls.Add(btnSettings);
            flpnav.Dock = DockStyle.Fill;
            flpnav.FlowDirection = FlowDirection.TopDown;
            flpnav.Font = new Font("Segoe UI", 9F);
            flpnav.Location = new Point(0, 0);
            flpnav.Margin = new Padding(2, 3, 2, 3);
            flpnav.Name = "flpnav";
            flpnav.Size = new Size(178, 573);
            flpnav.TabIndex = 1;
            //flpnav.Paint += flpnav_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.dash;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(2, 3);
            btnDashboard.Margin = new Padding(2, 3, 2, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(9, 0, 0, 0);
            btnDashboard.Size = new Size(173, 60);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Image = Properties.Resources.product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(2, 69);
            btnProducts.Margin = new Padding(2, 3, 2, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(9, 0, 0, 0);
            btnProducts.Size = new Size(169, 60);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Image = Properties.Resources.order;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(2, 201);
            btnOrder.Margin = new Padding(2, 3, 2, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(9, 0, 0, 0);
            btnOrder.Size = new Size(170, 60);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Image = Properties.Resources.reports;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(2, 267);
            btnReports.Margin = new Padding(2, 3, 2, 3);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(9, 0, 0, 0);
            btnReports.Size = new Size(169, 60);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSync.Image = Properties.Resources.ico_sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(2, 333);
            btnSync.Margin = new Padding(2, 3, 2, 3);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(9, 0, 0, 0);
            btnSync.Size = new Size(169, 60);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogs.Image = Properties.Resources.log;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(2, 399);
            btnLogs.Margin = new Padding(2, 3, 2, 3);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(9, 0, 0, 0);
            btnLogs.Size = new Size(169, 60);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Image = Properties.Resources.setting;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(2, 465);
            btnSettings.Margin = new Padding(2, 3, 2, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(9, 0, 0, 0);
            btnSettings.Size = new Size(169, 60);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
//            btnSettings.Click += btnSettings_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI", 9F);
            pnlContent.Location = new Point(178, 60);
            pnlContent.Margin = new Padding(2, 3, 2, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(656, 573);
            pnlContent.TabIndex = 2;
            //pnlContent.Paint += panelContent_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 633);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 13, 0);
            statusStrip1.Size = new Size(834, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(51, 20);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // btnCustomer
            // 
            btnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(2, 135);
            btnCustomer.Margin = new Padding(2, 3, 2, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(9, 0, 0, 0);
            btnCustomer.Size = new Size(170, 60);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 659);
            Controls.Add(pnlContent);
            Controls.Add(panelLeft);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).EndInit();
            flpleft.ResumeLayout(false);
            flpleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            panelLeft.ResumeLayout(false);
            flpnav.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.FlowLayoutPanel flpnav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblMiniStore;
        private Button btnCustomer;
    }
}