using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Class_122_Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();
        Product currentProduct = null;
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayInformation();
            DisplayInformation();
            DisplayInformation();
        }


        void Preload()
        
        {

            Random rand = new Random();
           
            int end = 106;

            for (int i = 100; i < end; i++)
            {
                string productName = "Red Bull:" + i;
                
                
                if (rand.Next(2) != 0)
                {
                   products.Add(new Product(productName));
                }
                else
                {
                    products.Add(new Product(productName, false)) ;
                }
            }
        }




        public void DisplayInformation()
        {

            // Clear the listbox
            lbProducts.Items.Clear();


            for (int i = 0; i < products.Count; i++)
            {
                lbProducts.Items.Add(products[i]);
            }
        }

        public string DisplayInformationToRun(Product product)
        {
            string formattedString = $"" +
                $"Product Name: {product.Name}\n" +
                $"Sku: {product.Sku}\n";

            if(product.inStock)
            {
              formattedString += $"This product is in stock";

            }
            else 
            {

              
                formattedString += $"This product is out of stock";
            }

            return formattedString;
        }

        private void lbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbProducts.SelectedIndex;
            currentProduct = products[selectedIndex];

            DisplayInformation();
            DisplayInformationToRun(currentProduct);
        }
        
           
    }

}
