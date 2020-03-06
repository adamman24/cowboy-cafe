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

namespace CowboyCafe.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// interface for order control class
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new Order();
            CancelOrderButton.Click += onCancelOrderButtonClicked;
            CompleteOrderButton.Click += onCompleteOrderButtonClicked;
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// when cancel order clicked incriment order number and clears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// completes order and increments order number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

    }
}
