using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DllProductLibrary;

using SampleLibDLL;

namespace SampleWebApp
{
    public partial class Products : System.Web.UI.Page
    {
        ProductRepoClass pr = new ProductRepoClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = pr.getAllProducts();
                //   ProductRepo.AllProducts;
                foreach (var item in data)
                    lstProducts.Items.Add(new ListItem
                    {
                        Text = item.ProductName,
                        Value = item.ProductId.ToString()
                    });
                
            }
        }

        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(lstProducts.SelectedValue);
            var selected = pr.getAllProducts().FirstOrDefault((p) => p.ProductId == id);
           // var selected = ProductRepo.AllProducts.FirstOrDefault((p) => p.ProductId == id);
            txtName.Text = selected.ProductName;
            txtPrice.Text = selected.ProductPrice.ToString();
            imgPic.ImageUrl = selected.ProductImage;
            txtId.Text = selected.ProductId.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductImage = imgPic.ImageUrl,
                ProductPrice = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                ProductQuantity = int.Parse(dpQuantity.Text)
            };
            pr.updateProduct(product);
           // ProductRepo.updateProduct(product);
            Response.Redirect("Products.aspx");
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
           pr.removeProduct(int.Parse(txtId.Text));
            Response.Redirect("Products.aspx");
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductImage = imgPic.ImageUrl,
                ProductPrice = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                ProductQuantity = int.Parse(dpQuantity.Text)
            };
            pr.addProduct(product);
            Response.Redirect("Products.aspx");
        }
        
    }
}