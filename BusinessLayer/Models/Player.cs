using MTGC.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGC.BusinessLayer.Models
{
    public class Player
    {
        public string Username { get; }
        public Deck CurrentDeck { get; set; }
        public List<ICard> Stack { get; }
        public int Coins { get; set; }

        public Player(string username, int initialCoins)
        {
            Username = username;
            Stack = new List<ICard>();
            Coins = initialCoins;
            CurrentDeck = new Deck();
        }

        public void AddCardToStack(ICard card)
        {
            Stack.Add(card);
        }

        public void RemoveCardFromStack(ICard card)
        {
            Stack.Remove(card);
        }

        public void AddCardToDeck(ICard card)
        {
            throw new NotImplementedException();
        }
    }

}
