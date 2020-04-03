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
    /// Interaction logic for TexasTeaCustomization.xaml
    /// </summary>
    public partial class TexasTeaCustomization : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order linkToOrder;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public TexasTeaCustomization(object dc)
        {
            linkToOrder = (Order)dc;
            InitializeComponent();
        }

        private void SizeButtonClicked(object sender, RoutedEventArgs e)
        {
            TexasTea texasTea;
            if (DataContext is TexasTea)
            {
                texasTea = (TexasTea)DataContext;
                switch (((Button)sender).Name)
                {
                    //Size Cases
                    case "SmallButton":
                        texasTea.Size = Size.Small;
                        break;
                    case "MediumButton":
                        texasTea.Size = Size.Medium;
                        break;
                    case "LargeButton":
                        texasTea.Size = Size.Large;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size Button Pressed");
                }

                linkToOrder.UpdateAllProperties();
            }

        }
    }
}
