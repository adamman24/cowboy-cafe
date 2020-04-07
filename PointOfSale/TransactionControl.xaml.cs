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
using CashRegister;

namespace CowboyCafe.PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private Order order;
        public TransactionControl(Order order1)
        {

            InitializeComponent();
            this.DataContext = order1;
            order = order1;
        }

        void onPayWithCashButtonClicked(object sender, RoutedEventArgs e)
        {
            var cashDrawer = new CashRegister.CashDrawer();
        }

        void onPayWithCardButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal cardTerminal = new CardTerminal();
            if (DataContext is Order order)
            {
                ResultCode resultCode = cardTerminal.ProcessTransaction(order.total);

                switch(resultCode)
                {
                    case ResultCode.Success:
                        PrintRecipt();
                        MessageBox.Show("Transaction Complete!");
                        SwapScreenOrderControl();
                        break;
                    default:
                        MessageBox.Show(resultCode.ToString());
                        break;
                }
            }
        }
        
        void onCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new OrderSummaryControl();
            orderControl.SwapScreen(screen);
            this.DataContext = new OrderControl();
        }

        private void SwapScreenOrderControl()
        {
            OrderControl orderControl = new OrderControl();
            var mainWindow = this.FindAncestor<MainWindow>();
            if (mainWindow == null) return;
            mainWindow.SwapMainScreen(orderControl);
        }

        /// <summary>
        /// swap to drawer screen
        /// </summary>
        /// <param name="element"></param>
        void SwapScreenDrawer(UIElement element)
        {
            TransactionMethod.Child = element;
        }

        /// <summary>
        /// swap to input screen
        /// </summary>
        /// <param name="element"></param>
        public void swapInputScreen(UIElement element)
        {
            Container.Child = element;
        }

        private void PrintRecipt()
        {
            StringBuilder s = new StringBuilder();
            foreach(IOrderItem item in order.Items)
            {
                s.Append(item);
                s.Append("\n");
            }

            ReceiptPrinter reciptPrinter = new ReceiptPrinter();
            reciptPrinter.Print("Order Number #" + order.OrderNumber + DateTime.Now + "\nItems Ordered \n" + s.ToString() + "\nSubtotal" + order.Subtotal
                + "\nTotal: $" + order.total +"\nPayed with Credit Card" );
        }
        
    }
}
