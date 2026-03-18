using App.core.Contracts;
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
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;
        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
        {
            InitializeComponent();


            NudPricePf.Maximum = Decimal.MaxValue;
            NudStockPF.Maximum = Int32.MaxValue;


            CmbCategory.Items.Clear();
            CmbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            CmbCategory.SelectedIndex = 0;

            CmbStatus.Items.Clear();
            CmbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            CmbStatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;



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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = (ProductCategoryEnum)CmbCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)CmbStatus.SelectedItem;
                newProduct.Price = NudPricePf.Value;
                newProduct.Stock = (int)NudStockPF.Value;


                //_service.Add(newProduct);
                Product temp = _service.Add(newProduct);
                txtIdPf.Text = temp?.Id ?? "";
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.Category = (ProductCategoryEnum)CmbCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)CmbStatus.SelectedItem;
                _product.Price = NudPricePf.Value;
                _product.Stock = (int)NudStockPF.Value;

                bool isUpdated = _service.Update(_product);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
