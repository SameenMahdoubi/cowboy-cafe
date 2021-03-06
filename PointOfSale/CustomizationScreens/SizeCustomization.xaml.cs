﻿/*
 * Author: Zachery Brunner
 * Class: SizeCustomization.xaml.cs
 * Purpose: Allows customization for any side's size
 * Last Modified 3/26/20
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

using System.ComponentModel;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SizeCustomization.xaml
    /// </summary>
    public partial class SizeCustomization : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order linkToOrder;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public SizeCustomization(object dc)
        {
            linkToOrder = (Order)dc;
            InitializeComponent();
        }

        /// <summary>
        /// Filters which control was pressed and changes the holding state of the respective item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Side s;
            Size size;
            if (DataContext is ChiliCheeseFries)
                s = (ChiliCheeseFries)DataContext;
            else if (DataContext is CornDodgers)
                s = (CornDodgers)DataContext;
            else if (DataContext is PanDeCampo)
                s = (PanDeCampo)DataContext;
            else
                s = (BakedBeans)DataContext;


            switch (((Button)sender).Name)
            {
                //Size Cases
                case "SmallButton":
                    size = Size.Small;                  
                    break;
                case "MediumButton":
                    size = Size.Medium;
                    break;
                case "LargeButton":
                    size = Size.Large;
                    break;
                default:
                    throw new NotImplementedException("Unknown Size Button Pressed");
            }
            s.Size = size;
            
            linkToOrder.UpdateAllProperties();
        }
    }
}