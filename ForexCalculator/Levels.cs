using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForexCalculator
{
    public class Levels
    {
        private double _buyTakeProfit, _buyStopLoss, _buyOrderLevel, _sellTakeProfit, _sellStopLoss, _sellOrderLevel;

        public double BuyTakeProfit
        {
            get { return this._buyTakeProfit; }
            set { this._buyTakeProfit = value; }
        }

        public double BuyStopLoss
        {
            get { return this._buyStopLoss; }
            set { this._buyStopLoss = value; }
        }

        public double BuyOrderLevel
        {
            get { return this._buyOrderLevel; }
            set { this._buyOrderLevel = value; }
        }
        
        public double SellTakeProfit
        {
            get { return this._sellTakeProfit; }
            set { this._sellTakeProfit = value; }
        }

        public double SellStopLoss
        {
            get { return this._sellStopLoss; }
            set { this._sellStopLoss = value; }
        }

        public double SellOrderLevel
        {
            get { return this._sellOrderLevel; }
            set { this._sellOrderLevel = value; }
        }
    }
}
