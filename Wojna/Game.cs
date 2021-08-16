using System;

namespace Wojna
{
    class Game
    {
        private Deck a;
        private Deck b;
        private int counter;

        public Game(Deck a, Deck b)
        {
            this.a = a;
            this.b = b;
            counter = 0;
        }
        public bool Combat(int x)
        {
            if ((a.GetCardXFromTop(x) != null && b.GetCardXFromTop(x) != null) && counter < 100000)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(a.GetCardXFromTop(x) + " vs " + b.GetCardXFromTop(x));
                    if (a.GetCardXFromTop(x).GetValue() > b.GetCardXFromTop(x).GetValue())
                    {
                        Console.WriteLine("Wygrywa gracz A! ===========================================================");
                        for (var i = 0; i < x + 1; i++)
                        {
                            a.AddCard(b.GetTopCard());
                            a.AddCard(a.GetTopCard());
                            a.RemoveTopCard();
                            b.RemoveTopCard();
                            Console.WriteLine("Tura " + counter++);
                        }
                    }
                    else if (a.GetCardXFromTop(x).GetValue() < b.GetCardXFromTop(x).GetValue())
                    {
                        Console.WriteLine("Wygrywa gracz B! ===========================================================");
                        for (var i = 0; i < x + 1; i++)
                        {
                            b.AddCard(a.GetTopCard());
                            b.AddCard(b.GetTopCard());
                            a.RemoveTopCard();
                            b.RemoveTopCard();
                            Console.WriteLine("Tura " + counter++);
                        }
                    }
                    else if (a.GetCardXFromTop(x).GetValue() == b.GetCardXFromTop(x).GetValue())
                    {
                        Console.WriteLine("Wojna! =====================================================================");
                        Combat(++x);
                    }
                }
                else
                {
                    Console.WriteLine("Chowam karty... ============================================================ ");
                    Combat(++x);
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public string Weener()
        {
            return a.IsEmpty() ? "Wygrywa gracz B!" : "Wygrywa gracz A!";
        }
    }
}
