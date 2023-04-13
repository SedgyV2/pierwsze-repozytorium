using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abonament.DataModels
{
    internal class AbonamentOffer
    {
        private int ContractDuratio;
        private double Price;
        private double discount;

        public int contractduratio 
        { 
            get
            {
                return ContractDuratio;
            }
        }
        public double price 
        { 
            get
            {
                return Price;
            }
        }
        public double Discount 
        { 
            get 
            {
                return discount;
            }
            set
            {   if (value > 50)
                {
                    value = 50;
                    discount = value;
                    
                }
                else
                {
                    discount = value;
                }
            }
        }

        public  AbonamentOffer(int contractDuratio, double Price, double discount)
        {   
            this.ContractDuratio = contractDuratio;
            this.Price = Price;
            this.Discount = discount;
        }

        public string UltimateGetter()
        {
            return $"Contract Duratio is {ContractDuratio} Months, Price is - {Price}PLN, discount is - {Discount}%";
        }

    }
}
