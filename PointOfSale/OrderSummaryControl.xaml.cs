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
using PointOfSale.CustomizationScreens;
using PointOfSale.CustomizationScreens.EntreeCustomizationScreens;
using PointOfSale.CustomizationScreens.DrinkCustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Accesses an existing list item for the order, allowing the user to change the details of that order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var selectedItem = (sender as ListBox).SelectedItem as IOrderItem;          

            FrameworkElement screen = null;
            if(selectedItem != null)
            {
                switch (selectedItem.ToString())
                {
                    case "Angry Chicken":
                        screen = new AngryChickenCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Cowpoke Chili":

                        screen = new CowpokeChiliCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Dakota Double Burger":

                        screen = new DakotaDoubleBurgerCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Pecos Pulled Pork":

                        screen = new PecosPulledPorkCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Trail Burger":

                        screen = new TrailBurgerCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Texas Triple Burger":

                        screen = new TexasTripleBurgerCustomization();
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Small Baked Beans":
                    case "Medium Baked Beans":
                    case "Large Baked Beans":
                    case "Small Chili Cheese Fries":
                    case "Medium Chili Cheese Fries":
                    case "Large Chili Cheese Fries":
                    case "Small Corn Dodgers":
                    case "Medium Corn Dodgers":
                    case "Large Corn Dodgers":
                    case "Small Pan De Campo":
                    case "Medium Pan De Campo":
                    case "Large Pan De Campo":

                        screen = new SizeCustomization(DataContext);
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Small Cowboy Coffee":
                    case "Small Decaf Cowboy Coffee":
                    case "Medium Cowboy Coffee":
                    case "Medium Decaf Cowboy Coffee":
                    case "Large Cowboy Coffee":
                    case "Large Decaf Cowboy Coffee":
                        screen = new CowboyCoffeeCustomization(DataContext);
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Small Texas Sweet Tea":
                    case "Small Texas Plain Tea":
                    case "Medium Texas Sweet Tea":
                    case "Medium Texas Plain Tea":
                    case "Large Texas Sweet Tea":
                    case "Large Texas Plain Tea":
                        screen = new TexasTeaCustomization(DataContext);
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    case "Small Water":
                    case "Medium Water":
                    case "Large Water":
                        screen = new WaterCustomization(DataContext);
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;

                    //Jerked Soda is set as default because it has 15 cases.
                    default:
                        screen = new JerkedSodaCustomization(DataContext);
                        screen.DataContext = selectedItem;
                        orderControl?.SwapScreen(screen);
                        break;
                }
            }
            
        }

        /// <summary>
        /// Removes an item from the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                
                if (sender is Button button)
                {
                    var removedItem = button.Tag as IOrderItem;
                    data.Remove(removedItem);
                }

            }
        }

    }
}
