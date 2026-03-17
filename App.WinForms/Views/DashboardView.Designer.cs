namespace App.WinForms.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tblKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSales = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnllowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.clmProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbllowStock = new System.Windows.Forms.Label();
            this.pnlRecentOrder = new System.Windows.Forms.Panel();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.clmOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCostumerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrder = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.tblKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnllowStock.SuspendLayout();
            this.pnlRecentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.Color.White;
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.tblKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnllowStock, 2, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrder, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(881, 554);
            this.tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            this.tblKpi.ColumnCount = 3;
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11258F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11259F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77484F));
            this.tblKpi.Controls.Add(this.pnlSales, 0, 0);
            this.tblKpi.Controls.Add(this.pnlOrders, 1, 0);
            this.tblKpi.Controls.Add(this.pnlRevenue, 2, 0);
            this.tblKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpi.Location = new System.Drawing.Point(19, 18);
            this.tblKpi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblKpi.Name = "tblKpi";
            this.tblKpi.RowCount = 1;
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpi.Size = new System.Drawing.Size(843, 116);
            this.tblKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(3, 2);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(273, 112);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesT.Location = new System.Drawing.Point(40, 35);
            this.lblSalesT.Margin = new System.Windows.Forms.Padding(40, 35, 37, 0);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(60, 30);
            this.lblSalesT.TabIndex = 1;
            this.lblSalesT.Text = "Sales";
            // 
            // lblSalesV
            // 
            this.lblSalesV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesV.Location = new System.Drawing.Point(149, 40);
            this.lblSalesV.Margin = new System.Windows.Forms.Padding(12, 35, 37, 0);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(42, 25);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "234";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Location = new System.Drawing.Point(282, 2);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(273, 112);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderV.Location = new System.Drawing.Point(142, 35);
            this.lblOrderV.Margin = new System.Windows.Forms.Padding(30, 35, 37, 0);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(32, 25);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "54";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderT.Location = new System.Drawing.Point(40, 38);
            this.lblOrderT.Margin = new System.Windows.Forms.Padding(30, 35, 37, 0);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(69, 25);
            this.lblOrderT.TabIndex = 1;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevenue.Location = new System.Drawing.Point(561, 2);
            this.pnlRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(279, 112);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(158, 35);
            this.lblRevenueV.Margin = new System.Windows.Forms.Padding(30, 35, 37, 0);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(107, 25);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "32,765 PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueT.Location = new System.Drawing.Point(30, 35);
            this.lblRevenueT.Margin = new System.Windows.Forms.Padding(30, 35, 37, 0);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(84, 25);
            this.lblRevenueT.TabIndex = 1;
            this.lblRevenueT.Text = "Revenue";
            this.lblRevenueT.Click += new System.EventHandler(this.lblRevenueT_Click);
            // 
            // pnllowStock
            // 
            this.pnllowStock.Controls.Add(this.lvLowStock);
            this.pnllowStock.Controls.Add(this.lbllowStock);
            this.pnllowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllowStock.Location = new System.Drawing.Point(19, 138);
            this.pnllowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnllowStock.Name = "pnllowStock";
            this.pnllowStock.Size = new System.Drawing.Size(843, 197);
            this.pnllowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProduct,
            this.clmStock});
            this.lvLowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLowStock.FullRowSelect = true;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 27);
            this.lvLowStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(843, 170);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.lvLowStock_SelectedIndexChanged);
            // 
            // clmProduct
            // 
            this.clmProduct.Text = "Product Name";
            // 
            // clmStock
            // 
            this.clmStock.Text = "Stock";
            // 
            // lbllowStock
            // 
            this.lbllowStock.AutoSize = true;
            this.lbllowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbllowStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllowStock.Location = new System.Drawing.Point(0, 0);
            this.lbllowStock.Name = "lbllowStock";
            this.lbllowStock.Size = new System.Drawing.Size(98, 25);
            this.lbllowStock.TabIndex = 0;
            this.lbllowStock.Text = "Low Stock";
            // 
            // pnlRecentOrder
            // 
            this.pnlRecentOrder.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrder.Controls.Add(this.lblOrder);
            this.pnlRecentOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrder.Location = new System.Drawing.Point(19, 341);
            this.pnlRecentOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRecentOrder.Name = "pnlRecentOrder";
            this.pnlRecentOrder.Size = new System.Drawing.Size(843, 193);
            this.pnlRecentOrder.TabIndex = 2;
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOrder,
            this.clmCostumerId,
            this.clmTotal,
            this.clmStatus});
            this.lvRecentOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRecentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecentOrder.FullRowSelect = true;
            this.lvRecentOrder.GridLines = true;
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Location = new System.Drawing.Point(0, 29);
            this.lvRecentOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(843, 164);
            this.lvRecentOrder.TabIndex = 1;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrder.View = System.Windows.Forms.View.Details;
            // 
            // clmOrder
            // 
            this.clmOrder.Text = "Order Id";
            // 
            // clmCostumerId
            // 
            this.clmCostumerId.Text = "Costumer Name";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(0, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(133, 25);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(881, 554);
            this.tblDashboard.ResumeLayout(false);
            this.tblKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnllowStock.ResumeLayout(false);
            this.pnllowStock.PerformLayout();
            this.pnlRecentOrder.ResumeLayout(false);
            this.pnlRecentOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.FlowLayoutPanel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnllowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lbllowStock;
        private System.Windows.Forms.ColumnHeader clmProduct;
        private System.Windows.Forms.ColumnHeader clmStock;
        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.ColumnHeader clmOrder;
        private System.Windows.Forms.ColumnHeader clmCostumerId;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Label lblOrder;
    }
}
