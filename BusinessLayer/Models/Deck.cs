using MTGC.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGC.BusinessLayer.Models
{
    public class Deck
    {
        public List<ICard> Cards { get; }

        public Deck()
        {
            Cards = new List<ICard>();
        }

        public void AddCard(ICard card)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard(ICard card)
        {
            Cards.Remove(card);
        }
    }

}
