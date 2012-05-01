using System;
using System.Collections.Generic;
using System.Linq;
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


namespace ForexCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Levels level1 = new Levels();
        public MainWindow()
        {
            InitializeComponent();
            
           


        }
        public void PriceChange(bool isBuy, Levels level)
        {
            
                //check if the text changed came from buy or sell price text box. true = buy, false = sell
            
            if(isBuy)
            {
                level.BuyTakeProfit = 1;
                level.BuyStopLoss = 2;
                level.BuyOrderLevel = 2;


            } 
             if (!isBuy)
            {
                level.SellTakeProfit = 1;
                level.SellStopLoss = 2;
                level.SellOrderLevel = 3;
            }else throw new ArgumentOutOfRangeException();

        }

        private void buyPriceText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           // sets text changed flag to show it came from buy text box
            PriceChange(true, level1);
            buyTakeProfitLabel.Content = (level1.BuyTakeProfit.ToString());



        }

        private void sellOrderText_TextChanged(object sender, TextChangedEventArgs e)
        {   
            // sets text changed flag to show it came from sell text box.
            PriceChange(false, level1);
        }
    }
}
