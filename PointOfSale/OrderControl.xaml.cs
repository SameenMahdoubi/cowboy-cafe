using System;
using System.Collections.Generic;
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Adds a TrailBurger to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Adds a Rustler's Ribs to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Adds a Pecos Pulled Pork to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Adds a Texas Triple Burger to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Adds a Dakota Double to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Adds an Angry Chicken to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Adds a Cowpoke Chili to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        // Divider for readability, separating Entrees from Sides

        /// <summary>
        /// Adds an order of Baked Beans to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Adds an order of Chili Cheese Fries to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Adds an order of Corn Dodgers to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Adds an order of Pan de Campo to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }


        // Divider between sides and drinks

        /// <summary>
        /// Adds a Cowboy Coffee to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Adds a Jerked Soda to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Adds a Texas Tea to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Adds a water to the list of items on the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }
    }
}
