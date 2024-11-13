using ERP.SGA.Models.Products;
using ERP.SGA.WinApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ERP.SGA.WinApp
{
    /// <summary>
    /// Lógica de interacción para ProductCrud.xaml
    /// </summary>
    public partial class ProductCrud : Window
    {
        public delegate void pasarNuevoProducto(ProductType nuevoProducto);
        public event pasarNuevoProducto ObtNuevo_Producto;
        ProductType productType;

        public ProductCrud(ProductType productTypeEntity)
        {
            InitializeComponent();

            if (productTypeEntity != null)
            {
                productType = productTypeEntity;
            }
            else { productType = new ProductType(); }

            Inicial();
        }

        public void Inicial()
        {
            if (productType != null)
            {
                txtName.Text = productType.Name;
                txtComment.Text = productType.Comment;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductType nuevoProducto = new ProductType();
            nuevoProducto.Name = txtName.Text;
            nuevoProducto.Comment = txtComment.Text;
            nuevoProducto.CategoryId = 1;

            using (var conext = new ApplicationDbContext())
            {
                conext.ProductType.Add(nuevoProducto);
                conext.SaveChanges();
            }

            if (ObtNuevo_Producto != null)
                ObtNuevo_Producto(nuevoProducto);
            this.Close();
        }
    }
}
