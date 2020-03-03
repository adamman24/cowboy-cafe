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
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// creates new order list
        /// </summary>

        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += onAddCowpokeChiliButtonClicked;
            AddAngryChickenButon.Click += onAddAngryChickenButonClicked;
            AddDakotaDoubleButton.Click += onAddDakotaDoubleButtonClicked;
            AddRustlersRibsButton.Click += onAddRustlersRibsButtonClicked;
            AddTexasTripleButton.Click += onAddTexasTripleBurgerButtonClicked;
            AddPecosPulledPorkButton.Click += onAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += onAddTrailBurgerButtonClicked;
            AddChiliCheeseFriesButton.Click += onAddChiliCheeseFriesButtonClicked;
            AddPanDeCampoButton.Click += onAddPanDeCampoButtonClicked;
            AddCornDodgersButton.Click += onAddCornDodgersButtonClicked;
            AddWaterButton.Click += onAddWaterButtonClicked;
            AddCowboyCoffeeButton.Click += onAddCowboyCoffeeButtonClicked;
            AddTexasTeaButton.Click += onAddTexasTeaButtonClicked;
            AddJerkedSodaButton.Click += onAddJerkedSodaButtonClicked;
            AddBakedBeansButton.Click += onAddBakedBeansButtonClicked;
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddAngryChickenButonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddDakotaDoubleButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// when add button clicked it adds to the list of items on order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }
    }
}
