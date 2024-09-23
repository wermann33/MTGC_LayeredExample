using MTGC.BusinessLayer.Controller;
using MTGC.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGC.PresentationLayer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Spieler erstellen
            Player player1 = new Player("Player1", 20);
            Player player2 = new Player("Player2", 20);
            Player player3 = new Player("Player2", 20);
            Player player4 = new Player("Player2", 20);

            //Verwende die Singleton Instanz des BattleManagers
            BattleManager.Instance.StartBattle(player1, player2);

            //Verwende weitere Instanz (bleibt aber in Wirklichkeit die gleiche)
            BattleManager.Instance.StartBattle(player3, player4);

            //Überprüfe, ob nur eine Instanz des Battlemanagers vorhanden ist
            if (BattleManager.Instance == BattleManager.Instance)
            {
                Console.WriteLine("Es gibt nur eine Instanz des BattleManagers");
            }
            else
            {
                Console.WriteLine("Es gibt mehrere Instanzen des BattleManagers");
            }

            // Monsterkarten erstellen
            MonsterCard goblin = new MonsterCard("Goblin", 20);
            MonsterCard dragon = new MonsterCard("Dragon", 50);
            MonsterCard wizard = new MonsterCard("Wizard", 40);
            MonsterCard ork = new MonsterCard("Ork", 30);

            // Zauberkarten erstellen
            SpellCard fireSpell = new SpellCard("Fire Spell", 25, ElementTypes.FIRE);
            SpellCard waterSpell = new SpellCard("Water Spell", 35, ElementTypes.WATER);

            // Karten zu den Spielern hinzufügen
            player1.AddCardToStack(goblin);
            player1.AddCardToStack(dragon);
            player2.AddCardToStack(wizard);
            player2.AddCardToStack(ork);
            player1.AddCardToStack(fireSpell);
            player2.AddCardToStack(waterSpell);

            //// Decks der Spieler erstellen
            //player1.AddCardToDeck(goblin);
            //player1.AddCardToDeck(dragon);
            //player2.AddCardToDeck(wizard);
            //player2.AddCardToDeck(waterSpell);

            //Console.WriteLine("\nStarting Battle between Goblin and Dragon:");
            //battleManager.StartBattle(goblin, dragon);

            //Console.WriteLine("\nStarting Battle between Wizard and Ork:");
            //battleManager.StartBattle(wizard, ork);

            //Console.WriteLine("\nStarting Battle between Fire Spell and Water Spell:");
            //battleManager.StartBattle(fireSpell, waterSpell);

            //// Handel initiieren
            //TradingMechanism tradingMechanism = new TradingMechanism();
            //Console.WriteLine("\nInitiating trade between Player1 and Player2:");
            //tradingMechanism.InitiateTrade(player1, dragon, ork);

            //// Spieler akzeptiert den Handel
            //Console.WriteLine("\nPlayer2 accepts the trade:");
            //tradingMechanism.AcceptTrade(player2, dragon, player1);

            //// Überprüfen, ob die Karten gehandelt wurden
            //Console.WriteLine($"\n{player1.Username} now has {player1.Stack.Count} cards.");
            //Console.WriteLine($"\n{player2.Username} now has {player2.Stack.Count} cards.");

            // Kartenspielergebnisse und Logs
            Console.WriteLine("\nEnd of Game.");
        }
    }

}
