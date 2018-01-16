using System;
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
            //DEBUG
            Gara g = Gara.GetInstance();
            Demo(g);

            /*
            //APPLICAZIONE
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

            try
            {
                DemoCreate(g, s, a1, a2, a3);
                DemoAmministration(g);
                DemoRemove(g, s, a1, a2, a3);
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
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

        private static void DemoAmministration(Gara g)
        {
            List<Atleta> aList = g.Atleti;
            List<Disciplina> dList = g.DisciplineInGara;
            Prestazione p1 = new Prestazione(dList[0]);
            Prestazione p2 = new Prestazione(dList[0]);
            Prestazione p3 = new Prestazione(dList[0]);
            Prestazione p4 = new Prestazione(dList[0]);
            Prestazione p5 = new Prestazione(dList[0]);
            Prestazione p6 = new Prestazione(dList[0]);

            p1.IsCompletata = true;
            p2.IsCompletata = true;
            p3.IsCompletata = true;
            p4.IsCompletata = true;
            p5.IsCompletata = true;
            p6.IsCompletata = true;

            g.AddAtletaToGara(aList[0], dList);
            g.AddPrestazioneToAtleta(aList[0], dList[0], p1);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n",dList[0] ,aList[0].Nome, aList[0].Cognome);
            g.AddPrestazioneToAtleta(aList[0], dList[1], p2);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n", dList[1], aList[0].Nome, aList[0].Cognome);
            g.printGara();

            Console.Write("\n----------------------------\n");


            g.AddAtletaToGara(aList[1], dList);
            g.AddPrestazioneToAtleta(aList[1], dList[0], p3);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n", dList[0], aList[0].Nome, aList[1].Cognome);
            g.AddPrestazioneToAtleta(aList[1], dList[1], p4);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n", dList[1], aList[0].Nome, aList[1].Cognome);
            g.printGara();

            Console.Write("\n----------------------------\n");

            g.AddAtletaToGara(aList[2], dList);
            g.AddPrestazioneToAtleta(aList[2], dList[0], p5);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n", dList[0], aList[2].Nome, aList[2].Cognome);
            g.AddPrestazioneToAtleta(aList[2], dList[1], p6);
            Console.Write("Aggiunta prestazione del tipo {0} all'atleta {1} {2}.\n", dList[1], aList[2].Nome, aList[2].Cognome);
            g.printGara();

            Console.Write("\n----------------------------\n");
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
            Console.Write("Rimossa Disciplina STA\n");
            g.printGara();
            Console.Write("\n");

            g.RemoveSpecialitàGara(Disciplina.CAM);
            Console.Write("Rimossa Disciplina CAM\n");
            g.printGara();
            Console.Write("\n");
        }
    }
}
