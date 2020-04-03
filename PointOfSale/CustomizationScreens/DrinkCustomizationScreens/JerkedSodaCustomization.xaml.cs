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
using System.Windows.Shapes;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;
using SodaFlavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale.CustomizationScreens.DrinkCustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order linkToOrder;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public JerkedSodaCustomization(object dc)
        {
            linkToOrder = (Order)dc;
            InitializeComponent();
        }


        private void SizeButtonClicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda jerkedSoda;
            if (DataContext is JerkedSoda)
            {
                jerkedSoda = (JerkedSoda)DataContext;
                switch (((Button)sender).Name)
                {
                    //Size Cases
                    case "SmallButton":
                        jerkedSoda.Size = Size.Small;
                        break;
                    case "MediumButton":
                        jerkedSoda.Size = Size.Medium;
                        break;
                    case "LargeButton":
                        jerkedSoda.Size = Size.Large;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size Button Pressed");
                }

                linkToOrder.UpdateAllProperties();
            }

        }


        private void FlavorButtonClicked(object sender, RoutedEventArgs e)
        {

            JerkedSoda jerkedSoda;
            if (DataContext is JerkedSoda)
            {
                jerkedSoda = (JerkedSoda)DataContext;
                switch (((Button)sender).Name)
                {
                    //Size Cases
                    case "CreamSoda":
                        jerkedSoda.Flavor = SodaFlavor.CreamSoda;
                        break;
                    case "OrangeSoda":
                        jerkedSoda.Flavor = SodaFlavor.OrangeSoda;
                        break;
                    case "Sarsparilla":
                        jerkedSoda.Flavor = SodaFlavor.Sarsparilla;
                        break;
                    case "BirchBeer":
                        jerkedSoda.Flavor = SodaFlavor.BirchBeer;
                        break;
                    case "RBeer":
                        jerkedSoda.Flavor = SodaFlavor.RootBeer;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Flavor Button Pressed");
                }

                linkToOrder.UpdateAllProperties();
            }

        }

    }
}

