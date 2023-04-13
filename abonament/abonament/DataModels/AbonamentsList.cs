using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abonament.DataModels
{
    internal class AbonamentsList
    {
        private List<AbonamentOffer> OffertList = new List<AbonamentOffer>();

        public AbonamentsList()
        {
            OffertList = new List<AbonamentOffer>();
        }

        public void AddOffert(AbonamentOffer offert)
        {
            OffertList.Add(offert);
        }

        public AbonamentOffer LowestPrice()
        {
            return OffertList.OrderBy(o => o.price).First();
        }

        public AbonamentOffer shortesttime()
        {
            return OffertList.OrderBy(o => o.contractduratio).First();
        }
        
    }
}
