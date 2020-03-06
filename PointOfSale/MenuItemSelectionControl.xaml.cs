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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        /// <summary>
        /// creates new order list
        /// </summary>\
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            AddCowpokeChiliButton.Click += OnItemAddButtonClicked;
            AddAngryChickenButon.Click += OnItemAddButtonClicked;
            AddDakotaDoubleButton.Click += OnItemAddButtonClicked;
            AddRustlersRibsButton.Click += OnItemAddButtonClicked;
            AddTexasTripleButton.Click += OnItemAddButtonClicked;
            AddPecosPulledPorkButton.Click += OnItemAddButtonClicked;
            AddTrailBurgerButton.Click += OnItemAddButtonClicked;
            AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;
            AddPanDeCampoButton.Click += OnItemAddButtonClicked;
            AddCornDodgersButton.Click += OnItemAddButtonClicked;
            AddWaterButton.Click += OnItemAddButtonClicked;
            AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;
            AddTexasTeaButton.Click += OnItemAddButtonClicked;
            AddJerkedSodaButton.Click += OnItemAddButtonClicked;
            AddBakedBeansButton.Click += OnItemAddButtonClicked;
        }
        /// <summary>
        /// adds item to list and open customization screen if it can
        /// be customized
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // need order to add item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an order instance");

            //not all items are cusomizable
            if (screen != null)
            {
                //need ordercontorl nacestor to load customization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor o ordercontrol expected");

                //add item to customization screen and launch screen
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }

        /// <summary>
        /// whenver a button is clicked this will run switches for
        /// tags on the button names to find which item to add
        /// to the order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var item = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(item, screen);

                            //var entree = new CowpokeChili();
                            //order.Add(entree);
                            //var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            //order.Add(entree);
                            //orderControl.SwapScreen(screen);
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());

                            break;
                        case "DakotaDouble":
                            order.Add(new DakotaDoubleBurger());

                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());

                            break;
                        case "TexasTriple":
                            order.Add(new TexasTripleBurger());

                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());

                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());

                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());

                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());

                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());

                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());

                            break;
                        case "Water":
                            order.Add(new Water());

                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());

                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());

                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());

                            break;
                        default:
                            break;
                    }
                }
            }
            
        }
    }
}
