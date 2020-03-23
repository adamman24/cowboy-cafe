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
                            var chicken = new AngryChicken();
                            var chickenScreen = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationScreen(chicken, chickenScreen);

                            break;
                        case "DakotaDouble":
                            var dakota = new DakotaDoubleBurger();
                            var dakotaScreen = new CustomizeDakotaDouble();
                            AddItemAndOpenCustomizationScreen(dakota, dakotaScreen);

                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());

                            break;
                        case "TexasTriple":
                            var texas = new TexasTripleBurger();
                            var texasScreen = new CustomizeTexasTriple();
                            AddItemAndOpenCustomizationScreen(texas, texasScreen);

                            break;
                        case "PecosPulledPork":
                            var pork = new PecosPulledPork();
                            var porkScreen = new CustomizePecosPulledPork();
                            AddItemAndOpenCustomizationScreen(pork, porkScreen);

                            break;
                        case "TrailBurger":
                            var trail = new TrailBurger();
                            var trailScreen = new CustomizeTrailBurger();
                            AddItemAndOpenCustomizationScreen(trail, trailScreen);

                            break;
                        case "ChiliCheeseFries":
                            var fries = new ChiliCheeseFries();
                            var friesScreen = new CustomizeSide();
                            AddItemAndOpenCustomizationScreen(fries, friesScreen);

                            break;
                        case "PanDeCampo":
                            var panDeCampo = new PanDeCampo();
                            var panDeCampoScreen = new CustomizeSide();
                            AddItemAndOpenCustomizationScreen(panDeCampo, panDeCampoScreen);

                            break;
                        case "BakedBeans":
                            var beans = new BakedBeans();
                            var beansScreen = new CustomizeSide();
                            AddItemAndOpenCustomizationScreen(beans, beansScreen);

                            break;
                        case "CornDodgers":
                            var dodgers = new CornDodgers();
                            var dodgersScreen = new CustomizeSide();
                            AddItemAndOpenCustomizationScreen(dodgers, dodgersScreen);

                            break;
                        case "Water":
                            var water = new Water();
                            var waterScreen = new CustomizeWater();
                            AddItemAndOpenCustomizationScreen(water, waterScreen);

                            break;
                        case "CowboyCoffee":
                            var coffee = new CowboyCoffee();
                            var coffeeScreen = new CustomizeCowboyCoffee();
                            AddItemAndOpenCustomizationScreen(coffee, coffeeScreen);

                            break;
                        case "TexasTea":
                            var tea = new TexasTea();
                            var teaScreen = new CustomizeTexasTea();
                            AddItemAndOpenCustomizationScreen(tea, teaScreen);

                            break;
                        case "JerkedSoda":
                            var soda = new JerkedSoda();
                            var sodaScreen = new CustomizeJerkedSoda();
                            AddItemAndOpenCustomizationScreen(soda, sodaScreen);

                            break;
                        default:
                            break;
                    }
                }
            }
            
        }
    }
}
