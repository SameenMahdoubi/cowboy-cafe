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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens.DrinkCustomizationScreens
{
    /// <summary>
    /// Interaction logic for WaterCustomization.xaml
    /// </summary>
    public partial class WaterCustomization : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order linkToOrder;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public WaterCustomization(object dc)
        {
            linkToOrder = (Order)dc;
            InitializeComponent();
        }

        private void SizeButtonClicked(object sender, RoutedEventArgs e)
        {
            Water water;
            if(DataContext is Water)
            {
                water = (Water)DataContext;
                switch (((Button)sender).Name)
                {
                    //Size Cases
                    case "SmallButton":
                        water.Size = Size.Small;
                        break;
                    case "MediumButton":
                        water.Size = Size.Medium;
                        break;
                    case "LargeButton":
                        water.Size = Size.Large;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size Button Pressed");
                }

                linkToOrder.UpdateAllProperties();
            }

        }
    }
}
