using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Nortwind_DB_First.Models;

namespace Nortwind_DB_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NorthwindContext _dbContext = new NorthwindContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCategory.DataSource = _dbContext.Categories.Include(x => x.Products).ThenInclude(x=>x.OrderDetails).ToList();
            lstCategory.DisplayMember = "CategoryName";
            
        }

        private Category _selectedCategory;

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;

            _selectedCategory = (Category)lstCategory.SelectedItem;

            lstProduct.DataSource = _selectedCategory.Products.ToList();

            //lstProduct.DataSource = _dbContext.Products.Where(x=> x.CategoryId == _selectedCategory.CategoryId).ToList();
            lstProduct.DisplayMember = "ProductName";
           
        }

        private Product _selectedProduct;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                CategoryId =_selectedCategory.CategoryId,
                ProductName = txtUrunAdi.Text,
                UnitPrice = nUrunFiyati.Value
            };

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItem == null) return;

            _selectedProduct = (Product)lstProduct.SelectedItem;
            txtUrunAdi.Text = _selectedProduct.ProductName;
            //if(_selectedProduct.UnitPrice.HasValue)
            //nUrunFiyati.Value = _selectedProduct.UnitPrice.Value;

            nUrunFiyati.Value = _selectedProduct.UnitPrice.GetValueOrDefault();

            Supplier productSupplier = _dbContext.Suppliers.FirstOrDefault(x => x.SupplierId == _selectedProduct.SupplierId);
            //Supplier productSupplier = _dbContext.Suppliers.Find(_selectedProduct.SupplierId);

            if (productSupplier != null)
            {
                this.Text = productSupplier.CompanyName;
            }

            listBox1.DataSource = _selectedProduct.OrderDetails.ToList();
            listBox1.DisplayMember = "OrderId";
        }

        private void bntGncll_Click(object sender, EventArgs e)
        {
            _selectedProduct.ProductName = txtUrunAdi.Text;
            _selectedProduct.UnitPrice = nUrunFiyati.Value;
            _dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _dbContext.Products.Remove(_selectedProduct);
            _dbContext.SaveChanges();
        }
    }
}
