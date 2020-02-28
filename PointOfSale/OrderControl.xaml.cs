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
        public OrderControl()
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

        void onAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            /*if(DataContext is Order order)
            {
                order.Add((IOrderItem)new BakedBeans());
            }*/
            
        }

        void onAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new JerkedSoda());
        }

        void onAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTea());
        }

        void onAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowboyCoffee());
        }

        void onAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
        }

        void onAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PanDeCampo());
        }

        void onAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CornDodgers());
        }

        void onAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChiliCheeseFries());
        }

        void onAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowpokeChili());
        }

        void onAddAngryChickenButonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new AngryChicken());
        }

        void onAddDakotaDoubleButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void onAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new RustlersRibs());
        }

        void onAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PecosPulledPork());
        }

        void onAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TrailBurger());
        }

        void onAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTripleBurger());
        }
    }
}
