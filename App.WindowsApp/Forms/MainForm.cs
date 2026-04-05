using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.core.Services;
using App.WindowsApp.Views;
namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private Button _activeNavButton;

        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 255);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;


        InMemoryProductService _productService = new InMemoryProductService();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();

        //  private readonly IProductService _productService = new InMemoryProductService();
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;

            //reset old active
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalFore;
                _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
            }

            //set new active 
            _activeNavButton = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavActiveFore;
            _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
        }
        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {


            ShowView(() => new ProductsView(_productService));
        }

        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {

        }

        private void btnLogs_Click(object sender, EventArgs e)
        {

        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;  //enum read karo
            }
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(view);
        }





        



    }
}
