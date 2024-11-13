using ERP.SGA.Models.Products;
using ERP.SGA.WinApp.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ERP.SGA.WinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelView modelView;
        ObservableCollection<ProductType> listadoDeTipos;
        CollectionViewSource fuentecollview;

        public MainWindow()
        {
            ObtenerDatosDB();
            this.DataContext = listadoDeTipos;

            InitializeComponent();

            modelView = new ModelView();
            //modelovista.Lista_Principal = gestorProductos.ObtenerProductos();
            //this.DataContext = modelView;

            fuentecollview = new CollectionViewSource();
            fuentecollview = Resources["FuenteVistaColeccion"] as CollectionViewSource;
            fuentecollview.Source = listadoDeTipos;
        }

        public void ObtenerDatosDB()
        {
            using (var conext = new ApplicationDbContext())
            {
                listadoDeTipos = new ObservableCollection<ProductType>();
                var listTipos = conext.Set<ProductType>().ToList();
                if (listTipos.Count > 0)
                {
                    foreach (var item in listTipos)
                    {
                        listadoDeTipos.Add(item);
                    }
                }
            }
        }

        public void EjecutarGuardadoCategory()
        {
            using (var context = new ApplicationDbContext())
            {
                //ProductCategory category = new ProductCategory();
                //category.Name = "Categoria 3";
                //category.Comment = "SD";
                //context.ProductCategory.Add(category);

                //ProductType productType = new ProductType();
                //productType.Name = "Tipo 2";
                //productType.Comment = "SD";
                //productType.Category = category;
                //context.ProductType.Add(productType);

                //context.SaveChanges();

                var listDb = context.Set<ProductType>().Where(x => x.Id == 1).ToList();
                var entityDb = listDb.First();
            }
        }
        public void EjecutarPruebaGuardado()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var productNew = new Product();

                    productNew.Name = "Product Test";
                    productNew.Stock = 10;
                    productNew.Code = "ASD1665";
                    productNew.Description = "Producto de Prueba";

                    ProductCategory category = new ProductCategory();
                    category.Name = "Categoria 1";
                    category.Comment = "SD";

                    context.ProductCategory.Add(category);

                    ProductType productType = new ProductType();
                    productType.Name = "Tipo 1";
                    productType.Comment = "SD";
                    productType.Enabled = true;
                    productType.Category = category;

                    context.ProductType.Add(productType);

                    productNew.Type = productType;

                    Cost cost = new Cost();
                    cost.Price = 1280;
                    cost.Utility = 120;
                    cost.SubTotal = cost.Price + cost.Utility;
                    cost.Total = cost.Total + cost.SubTotal;

                    context.Cost.Add(cost);

                    productNew.Cost = cost;

                    context.Product.Add(productNew);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AgregarProducto();
        }
        public void AgregarProducto()
        {
            ProductType selectedType;
            ProductCrud productCrud;
            if (dgvListaProductos.SelectedItem != null)
            {
                selectedType = dgvListaProductos.SelectedItem as ProductType;
                productCrud = new ProductCrud(selectedType);
            }
            else
            {
                productCrud = new ProductCrud(null);
            }

            productCrud.ObtNuevo_Producto += agregarProducto_ObtNuevo_Producto;
            productCrud.ShowDialog();
        }
        void agregarProducto_ObtNuevo_Producto(ProductType nuevoProducto)
        {
            listadoDeTipos.Add(nuevoProducto);
            //Producto producto_nuevo = controlProductos.LimpiarDatosBasicos(nuevoProducto);
            //modelovista.Lista_Principal.Add(producto_nuevo);
            int indice = listadoDeTipos.IndexOf(nuevoProducto);
            dgvListaProductos.SelectedIndex = indice;
        }
    }
}