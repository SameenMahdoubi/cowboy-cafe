/* MenuItemSelectionControl.xaml.cs
 * Author: Max Maus, with code taken with permission from Zachery Brunner
 * Last modified 3/27/20
 */

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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

            

        public void OnAddOrderItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    IOrderItem item;
                    FrameworkElement screen = null;
                    switch (button.Tag)
                    {
                        //cases for entrees
                        case "CowpokeChili":
                            
                            item = new CowpokeChili();
                            screen = new CowpokeChiliCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "AngryChicken":
                            
                            item = new AngryChicken();
                            screen = new AngryChickenCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "DakotaDoubleBurger":

                            item = new DakotaDoubleBurger();
                            screen = new DakotaDoubleBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "PecosPulledPork":

                            item = new PecosPulledPork();
                            screen = new PecosPulledPorkCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "TrailBurger":

                            item = new TrailBurger();
                            screen = new TrailBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "TexasTripleBurger":

                            item = new TexasTripleBurger();
                            screen = new TexasTripleBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                            // No screenswap is needed as the Ribs have no special instructions
                        case "RustlersRibs":

                            item = new RustlersRibs();
                            order.Add(item);                           
                            break;


                        // Separator for Sides

                        case "BakedBeans":
                            item = new BakedBeans();
                            screen = new SizeCustomization(DataContext);
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "ChiliCheeseFries":
                            item = new ChiliCheeseFries();
                            screen = new SizeCustomization(DataContext);
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "CornDodgers":
                            item = new CornDodgers();
                            screen = new SizeCustomization(DataContext);
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "PanDeCampo":
                            item = new PanDeCampo();
                            screen = new SizeCustomization(DataContext);
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        // And finally drinks

                        case "Water":
                            item = new Water();
                            screen = new WaterCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "JerkedSoda":
                            item = new JerkedSoda();
                            screen = new JerkedSodaCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "CowboyCoffee":
                            item = new CowboyCoffee();
                            screen = new CowboyCoffeeCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;

                        case "TexasTea":
                            item = new TexasTea();
                            screen = new TexasTeaCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                    
                }
            }
        }
    }
}
