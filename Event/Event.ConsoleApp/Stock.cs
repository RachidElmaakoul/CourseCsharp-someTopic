using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Event.ConsoleApp
{
    internal class Stock
    {
        public delegate void ChangeStockPriceHelperDelegate(Stock stock,decimal oldPrice);
        public event ChangeStockPriceHelperDelegate OnPriceChanged;

        private decimal _price;
        private string _name = "";

        public string Name => this._name;
        public decimal Price { get => this._price; set => this._price = value; }

        public Stock(string StockName)
        {
            this._name = StockName;
        }
        
        public void ChangeStockPriceBy(decimal percent)
        {
            decimal OldPrice = this._price;
            this._price += Math.Round(_price * percent, 2);

            if (OnPriceChanged != null)
            {
                OnPriceChanged(this,OldPrice);
            }

        }
       


    }
}
