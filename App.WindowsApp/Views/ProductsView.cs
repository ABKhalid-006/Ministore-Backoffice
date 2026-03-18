using App.core.Contracts;
using App.core.Models;
using App.core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;
        BindingSource _dgvbindingSource = new BindingSource();



        public ProductsView(IProductService _ser)
        {
            _service = _ser; // data binding google it 
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;

        }



        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<Object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;

            
            


            cmbStockStatus.Items.Clear();
            var stockStatus = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<Object>());
            cmbStockStatus.DataSource = stockStatus;
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;

            //_service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }

        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }
        private void RefreshGrid()
        {

            string searchText = txtSearch.Text;
            ProductCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmbCategory.SelectedItem;
                }
            }
            ProductStatusEnum? selectedStatus = null;
            if (cmbStockStatus.SelectedItem != null)
            {
                if (cmbStockStatus.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum)cmbStockStatus.SelectedItem;
                }
            }

            _dgvbindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
