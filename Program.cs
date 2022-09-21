using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Player Variables list.

            
            int Lives;
            Lives = 3;

            int Health;
            Health = 100;

            int Score;
            Score = 0;

            float ScoreMultipler;
            ScoreMultipler = 1.0f;

            int shield;
            shield = 100;



            //Item Variables List.


            int healthstim;
            healthstim = 25;

            int shieldpack;
            shieldpack = 25;

            int shieldkit;
            shieldkit = 100;

            int medkit;
            medkit = 100;



            //Enemie Variables List


            int enemiehitplayer;
            enemiehitplayer = -25;



            //Player Kudos Variable List

            int playerhitenemie;
            playerhitenemie = 10;

            int playerkillenemie;
            playerkillenemie = 25;








            







         
            

            //Genaric HUD

            Console.WriteLine("                      ========SomethingGame========");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Lives: " + Lives + "   Health: " + Health +  "                             Score: " + Score + "    Score Multiplier: " + ScoreMultipler);

            Console.WriteLine("");

            Console.WriteLine("Shield: " + shield);






            Console.ReadKey(true);

            shield = 50;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Lives: " + Lives + "   Health: " + Health + "                             Score: " + Score + "    Score Multiplier: " + ScoreMultipler);

            Console.WriteLine("");

            Console.WriteLine("Shield: " + shield);






            Console.ReadKey(true);
            Console.WriteLine("                      ========SomethingGame========");

            Console.WriteLine("                      ========SomethingGame========");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Lives: " + Lives + "   Health: " + Health + "                             Score: " + Score + "    Score Multiplier: " + ScoreMultipler);

            Console.WriteLine("");

            Console.WriteLine("Shield: " + shield);






            Console.ReadKey(true);

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Lives: " + Lives + "   Health: " + Health + "                             Score: " + Score + "    Score Multiplier: " + ScoreMultipler);

            Console.WriteLine("");

            Console.WriteLine("Shield: " + shield);






            Console.ReadKey(true);

        }
    }
}
