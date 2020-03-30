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
using CowboyCafe.Extensions;

namespace CowboyCafe.PointOfSale
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
        /// when an item in the order list is clicked
        /// it will return to the customization screen if it
        /// can be customized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemClick(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem item)
                {
                    if (item is AngryChicken chicken)
                    {
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = chicken;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } else if (item is CowpokeChili chili)
                    {
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = chili;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } else if (item is DakotaDoubleBurger dakota)
                    {
                        var screen = new CustomizeDakotaDouble();
                        screen.DataContext = dakota;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } else if (item is PecosPulledPork pork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pork;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } else if (item is TexasTripleBurger triple)
                    {
                        var screen = new CustomizeTexasTriple();
                        screen.DataContext = triple;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (item is TrailBurger trail)
                    {
                        var screen = new CustomizeTrailBurger();
                        screen.DataContext = trail;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (item is BakedBeans || item is CornDodgers|| item is ChiliCheeseFries || item is PanDeCampo)
                    {
                        var screen = new CustomizeSide();
                        screen.DataContext = item;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }else if (item is CowboyCoffee coffee)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = item;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }else if (item is JerkedSoda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = item;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (item is TexasTea)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = item;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (item is Water)
                    {
                        var screen = new CustomizeWater();
                        screen.DataContext = item;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                }

            }
        }
            
                    

        /// <summary>
        /// When x clicked it will remove item from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item)
                        {
                            data.Remove(item);
                        }
                }
    
            }
        }
    }
    
}
