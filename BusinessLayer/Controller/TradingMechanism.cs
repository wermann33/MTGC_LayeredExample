using MTGC.BusinessLayer.Interfaces;
using MTGC.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGC.BusinessLayer.Controller
{
    //Singleton
    class TradingMechanism
    {
        private static TradingMechanism? _instance;

        private TradingMechanism()
        {
            //Initialisierung, falls benötigt
        }

        //Öffentliche statische Methode, um die einzige Instanz zu erhalten
        public static TradingMechanism Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TradingMechanism();
                }
                return _instance;
            }
        }

        public void InitiateTrade(Player offerer, ICard offeredCard, ICard requestedCard)
        {
            throw new NotImplementedException();
        }

        public void AcceptTrade(Player accepter, ICard offeredCard, Player offerer)
        {
            throw new NotImplementedException();
        }
    }

}
