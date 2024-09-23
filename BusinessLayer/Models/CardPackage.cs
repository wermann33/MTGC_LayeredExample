using MTGC.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGC.BusinessLayer.Models
{
    public class CardPackage
    {
        public List<ICard> Cards { get; }

        public CardPackage()
        {
            Cards = new List<ICard>();
        }

        public void BuyPackage(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
