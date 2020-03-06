using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// find first ancestor in visual tree 
        /// that has he speicific type or null
        /// if no ancestor is found 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dependencyObject"></param>
        /// <returns>first ancestor with type found or null</returns>
        public static T FindAncestor<T>(this DependencyObject dependencyObject) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dependencyObject);

            if(parent is null)
            {
                return null;
            }

            if(parent is T)
            {
                return parent as T;
            }

            return FindAncestor<T>(parent);
        }
    }
}
