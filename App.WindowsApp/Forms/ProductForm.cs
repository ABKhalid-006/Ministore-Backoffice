using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();


            NudPricePf.Maximum = Decimal.MaxValue;
            NudStockPF.Maximum = Int32.MaxValue;


            CmbCategory.Items.Clear();
            CmbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            CmbCategory.SelectedIndex = 0;


            CmbStatus.Items.Clear();
            
            CmbStatus.DataSource =Enum.GetValues(typeof(ProductStatusEnum));
            CmbStatus.SelectedIndex = 0;


            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;

            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                
                txtIdPf.Text = p.Id;
                txtName.Text = p.Name;
                CmbCategory.SelectedItem = p.Category;
                CmbStatus.SelectedItem = p.Status;
                NudPricePf.Value = p.Price;
                NudStockPF.Value = p.Stock;
            }
           
        }
    }
}
