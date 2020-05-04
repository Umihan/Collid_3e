using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
 *  Collide
 *  Eine Simulation im 2-dimensionalen Raum
 *  Aufgabenaufteilung
 *  a) Sieder Fabian
 *  b) Raich Nikolas
 *  c) Hofer Lukas
 *  d) Thaler Hannes
 *  
 * 2020 TFO-Meran
 */

namespace ConsoleApplication1
{
    class Program
    {
        const int seite = 50;
        static int[,] feld = new int[seite, seite];

        class einer
        {
            // Private Eigenschaften
            Random r = new Random(); 
            // Öffentliche Eigenschaften
            public int posx, posy;
            public ConsoleColor farbe;
            // Konstruktor
            public einer()
            {
                do{
                    posx = r.Next(0, seite);
                    posy = r.Next(0, seite);
                } while (feld[posx,posy] == 1);
                feld[posx, posy] = 1;
                farbe = (ConsoleColor)(r.Next(Enum.GetNames(typeof(ConsoleColor)).Length));
            }
            //Private Methoden
            void show()
            {
                Console.SetCursorPosition(posx, posy);
                Console.Write("O");
            }
            void hide()
            {
            }
            void collide()
            {
                Move();
            }
            //Öffentliche Methoden
            public void Move()
            {
            }

        }

        static void Main(string[] args)
        {
            Console.WindowWidth = seite*2;
            Console.WindowHeight = seite;
            Console.Clear();
            Random ZG = new Random();
            int Anzahl=ZG.Next(1,6);
            einer[] meineEiner = new einer[Anzahl];
            for (int i = 0; i < Anzahl; i++)
            {
                meineEiner[i] = new einer();
            }
            Console.CursorVisible = false;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < Anzahl; j++)
                {
                    meineEiner[j].Move();
                }
                System.Threading.Thread.Sleep(10);

            }
        }
    }
}
