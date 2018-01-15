﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProgettoGIA.Model;
using ProgettoGIA.Persistence;
using ProgettoGIA.Presenter;

namespace ProgettoGIA
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Gara g = Gara.GetInstance();
            try
            {
                Demo(g);

            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }


            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            */
        }

        private static void Demo(Gara g)
        {
            Società s = new Società("societa1", "Bologna", Guid.Empty);
            Atleta a1 = new Atleta("Marco", "Tura", "TRUMRC91D04G916U", Sesso.MASCHIO, new DateTime(1991, 4, 4), false, s, new DateTime(2019, 1, 1), Guid.Empty);
            Atleta a2 = new Atleta("Anna", "Rossi", "TRUMRC91D04G916U", Sesso.FEMMINA, new DateTime(1994, 4, 4), false, s, new DateTime(2019, 1, 1), Guid.Empty);
            Atleta a3 = new Atleta("Jon", "Doo", "TRUMRC91D04G916U", Sesso.MASCHIO, new DateTime(2014, 4, 4), false, s, new DateTime(2017, 1, 1), Guid.Empty);



            DemoCreate(g, s, a1, a2, a3);
            DemoAmministration(g);
            //DemoRemove(g, s, a1, a2, a3);
        }

        private static void DemoAmministration(Gara g)
        {
            List<Atleta> aList = g.Atleti;
            List<Disciplina> dList = g.Discipline;
            Prestazione p = new Prestazione(dList[0], aList[0].Sesso);
            p.IsCompletata = true;

            g.AddAtletaToGara(aList[0], dList);
            g.AddPrestazioneToAtleta(aList[0], dList[0], p);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n",dList[0] ,aList[0].Nome, aList[0].Cognome);
            g.printGara();

        }

        private static void DemoCreate(Gara g, Società s, Atleta a1, Atleta a2, Atleta a3)
        {
            g.AddSpecialitàGara(Disciplina.STA);
            Console.Write("Creata disciplina STA\n");
            Console.Write("\n");

            g.AddSpecialitàGara(Disciplina.CAM);
            Console.Write("Creata disciplina CAM\n");
            Console.Write("\n");

            g.AddSocietà(s);
            Console.Write("Creata società1\n");
            g.printSocietà();
            Console.Write("\n");

            g.AddAtleta(a1);
            Console.Write("Creata a1\n");
            g.printAtleti();
            Console.Write("\n");

            g.AddAtleta(a2);
            Console.Write("Creata a2\n");
            g.printAtleti();
            Console.Write("\n");

            g.AddAtleta(a3);
            Console.Write("Creata a3\n");
            g.printAtleti();
            Console.Write("\n");
        }

        private static void DemoRemove(Gara g, Società s, Atleta a1, Atleta a2, Atleta a3)
        {
            g.RemoveAtleta(a3);
            Console.Write("Rimosso a3\n");
            g.printAtleti();
            Console.Write("\n");

            g.RemoveAtleta(a2);
            Console.Write("Rimosso a2\n");
            g.printAtleti();
            Console.Write("\n");

            g.RemoveAtleta(a1);
            Console.Write("Rimosso a1\n");
            g.printAtleti();
            Console.Write("\n");

            g.RemoveSocietà(s);
            Console.Write("Rimossa società1\n");
            g.printSocietà();
            Console.Write("\n");

            g.RemoveSpecialitàGara(Disciplina.STA);
            Console.Write("Rimossa Disciplina\n");
            g.printGara();
            Console.Write("\n");
        }
    }
}
