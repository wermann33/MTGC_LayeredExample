using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGC.BusinessLayer.Models;
using MTGC.BusinessLayer.Interfaces;

namespace MTGC.BusinessLayer.Controller
{  
    //Singleton
    class BattleManager
    {
        //Statische Instanz der Klasse
        private static BattleManager? _instance;

        public static BattleManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BattleManager();
                }

                return _instance;
            }
        }

        private BattleManager()
        {
            //Initialisierungscode
        }

        //
        public void StartBattle(ICard card1, ICard card2)
        {
            throw new NotImplementedException();
        }

        public void StartBattle(Player player1, Player player2)
        {
            Console.WriteLine("Not implemented yet");
        }
    }

}
