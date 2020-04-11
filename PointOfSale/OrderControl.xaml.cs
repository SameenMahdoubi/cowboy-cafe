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
using PointOfSale.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        CashDrawer drawer;

        Order order;

        public OrderControl()
        {
            InitializeComponent();
            SelectItemButton.Click += OnMenuItemSelectionButtonClicked;

            order = new Order();
            this.DataContext = order;

            drawer = new CashDrawer();
        }

        /// <summary>
        /// Removes a canceled order from the order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                this.DataContext = new Order();
            }
        }

        /// <summary>
        /// Sends the completed order to the cooks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                IOrderItem[] io = (IOrderItem[])order.Items;

                /* Check to make sure there is a transaction available */
                if (io.Length != 0)
                {
                    MainWindow mw = this.FindAncestor<MainWindow>();
                    mw.Container.Child = new TransactionControl(drawer, this);
                    
                    //this.DataContext = new Order();
                }
            }
        }

        public void OnMenuItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
