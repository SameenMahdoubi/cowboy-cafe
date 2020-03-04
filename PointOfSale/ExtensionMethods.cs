using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject //can only search for framework elements
        {
            var parent = VisualTreeHelper.GetParent(element); // part of windows.media

            if(parent == null)
            {
                return null;
            }

            if(parent is T)
            {
                return parent as T;
            }

            return parent.FindAncestor<T>();
        }
    }
}
