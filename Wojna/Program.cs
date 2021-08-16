using System;
using System.ComponentModel;

namespace Wojna
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck talia = new Deck("base");
            Deck Gracz_A = new Deck();
            Deck Gracz_B = new Deck();
            //for (var i = 0; i < talia.Count(); i++)//Przegląd talii podstawowej
            //{
            //    Console.WriteLine(talia.GetCardXFromTop(i));
            //}
            talia.ShuffleDeck();
            //Console.WriteLine("Tasowanie talii...=============================================================");
            //for (var i = 0; i < talia.Count(); i++)//Przegląd Talii podstawowej, potasowanej
            //{
            //    Console.WriteLine(talia.GetCardXFromTop(i));
            //}

            for (int i = 0; i < talia.Count() / 2; i++) //Rozdanie Talii A
            {
                Gracz_A.AddCard(talia.GetTopCard());
                talia.RemoveTopCard();
            }
            //Console.WriteLine("Talia A =====================================================");
            //for (var i = 0; i < Gracz_A.Count(); i++)//Przegląd talii A
            //{
            //    Console.WriteLine(Gracz_A.GetCardXFromTop(i));
            //}
            while (talia.IsEmpty() == false)// Rozdanie Talii B
            {
                Gracz_B.AddCard(talia.GetTopCard());
                talia.RemoveTopCard();
            }
            //Console.WriteLine("Talia B====================================================>");
            //for (var i = 0; i < Gracz_B.Count(); i++)//Przegląd talii B
            //{
            //    Console.WriteLine(Gracz_B.GetCardXFromTop(i));
            //}
            Game gra = new Game(Gracz_A, Gracz_B);
            while (gra.Combat(0) != true)
            {
            }
            Console.WriteLine("Koniec gry");
            Console.WriteLine(gra.Weener());
        }
    }
}
