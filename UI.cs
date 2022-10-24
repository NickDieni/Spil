namespace Blackjack1
{
    internal class UI
    {
        public static void Mellemrum()
        {
            Console.WriteLine();
        }
        public static void Color()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public static void Velkommen()
        {
            UI.Color();
            Console.WriteLine("Velkommen til mit spil");
            UI.Mellemrum();

        }
        public static void Menu()
        {
            //Kan altid tilføje flere valgmuligheder 
            Console.WriteLine("Tryk B for at vælge Blackjack");
        }
        public static void Main()
        {
        Start:
            UI.Color();
            Console.Clear();
            int Spillertal = 0, Dealerhånd = 0;
            int Dealerkort1, Dealerkort2, Dealerkort3, Dealerkort4, Dealerkort5;
            int Kort1, Kort2, NextKort, NextKort1, NextKort2, NextKort3;
            int Sleep = 1000;
            Console.WriteLine("BlackJack");
            Console.WriteLine();

            var random = new Random();

            Dealerkort1 = random.Next(1, 11);
            Dealerkort2 = random.Next(1, 11);

            if (Dealerkort1 == 1)
            {
                Dealerkort1 = 11;
            }
            if (Dealerkort2 == 1)
            {
                if (Spillertal > 10)
                {
                    Dealerkort2 = 1;
                }
                if (Spillertal <= 10)
                {
                    Dealerkort2 = 11;
                }
            }

            Dealerhånd = Dealerkort1 + Dealerkort2;

            Kort1 = random.Next(1, 11);
            Kort2 = random.Next(1, 11);

            if (Kort1 == 1)
            {
                Kort1 = 11;
            }

            Spillertal = Spillertal + Kort1;
            
            if (Kort2 == 1)
            {
                if (Spillertal > 10)
                {
                    Kort2 = 1;
                }
                if (Spillertal <= 10)
                {
                    Kort2 = 11;
                }
            }

            Spillertal = Spillertal + Kort2;
            
            if (Dealerhånd == 21)
            {
                Console.WriteLine("Dealer fik Blackjack");
                Console.WriteLine("");
                Console.WriteLine("Vent venligst");
                Thread.Sleep(Sleep);
                goto Start;
            }
            else
            {

                Console.WriteLine("Dealeren fik {0} og {1}, så dealer starter med {2}", Dealerkort1, Dealerkort2, Dealerhånd);
                Console.WriteLine("");
            }
            if (Spillertal == 21)
            {
                Console.WriteLine("Du fik Blackjack");
                Console.WriteLine("");
                Console.WriteLine("Tryk på en knap for at spille igen:");
                Console.WriteLine("Vent venligst");
                Thread.Sleep(Sleep);
                goto Start;
            }
            else
            {
                Console.WriteLine("Du fik {0} og {1}, så du starter med {2}", Kort1, Kort2, Spillertal);

                Console.WriteLine("");
                Console.WriteLine("Tryk D for at trække et nyt kort");
                Console.WriteLine("Tryk G for at stå");

                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                ClearCurrentConsoleLine();
                if (KeyInfo.Key == ConsoleKey.G || KeyInfo.Key == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.WriteLine("BlackJack");
                }
                if (KeyInfo.Key == ConsoleKey.D)
                {
                    NextKort = random.Next(1, 11);

                    if (NextKort == 1)
                    {
                        if (Spillertal > 10)
                        {
                            NextKort = 1;
                            Spillertal = Spillertal + NextKort;
                        }
                        if (Spillertal <= 10)
                        {
                            NextKort = 11;
                            Spillertal = Spillertal + NextKort;
                        }
                    }
                    else
                    {
                        Spillertal = Spillertal + NextKort;
                    }

                    if (Spillertal > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du fik over 21 så du tabte, din hånd var {0}", Spillertal);
                        Console.WriteLine("Tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(Sleep);
                        goto Start;

                    }
                    if (Spillertal == 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du fik 21");
                        Console.WriteLine("Tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(Sleep);
                        goto Start;
                    }
                    if (Spillertal < 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Dealer har {0}", Dealerhånd);
                        Console.WriteLine("Du fik {0}, så du har nu {1} ", NextKort, Spillertal);

                        Console.WriteLine("");
                        Console.WriteLine("Tryk D for at trække et nyt kort");
                        Console.WriteLine("Tryk G for at stå");


                        ConsoleKeyInfo Key1 = Console.ReadKey();
                        ClearCurrentConsoleLine();
                        if (Key1.Key == ConsoleKey.G || Key1.Key == ConsoleKey.D)
                        {
                            Console.Clear();
                            Console.WriteLine("BlackJack");
                        }
                        if (Key1.Key == ConsoleKey.D)
                        {
                            NextKort1 = random.Next(1, 11);

                            if (NextKort1 == 1)
                            {
                                if (Spillertal > 10)
                                {
                                    NextKort1 = 1;
                                    Spillertal = Spillertal + NextKort1;
                                }
                                if (Spillertal <= 10)
                                {
                                    NextKort1 = 11;
                                    Spillertal = Spillertal + NextKort1;
                                }
                            }
                            else
                            {
                                Spillertal = Spillertal + NextKort1;
                            }


                            if (Spillertal > 21)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du fik {0} så du kom over 21", Spillertal);
                                Console.WriteLine("");
                                Console.WriteLine("Tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                            if (Spillertal == 21)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du trukkede {0} så du har nu 21", NextKort1);
                                Console.WriteLine("");
                                Console.WriteLine("Tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                            if (Spillertal < 21)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du fik {0}, så du har nu {1} ", NextKort1, Spillertal);

                                Console.WriteLine("");
                                Console.WriteLine("Tryk D for at trække et nyt kort");
                                Console.WriteLine("Tryk G for at stå");

                                ConsoleKeyInfo Key2 = Console.ReadKey();
                                ClearCurrentConsoleLine();
                                if (Key2.Key == ConsoleKey.G || Key2.Key == ConsoleKey.D)
                                {
                                    Console.Clear();
                                    Console.WriteLine("BlackJack");
                                }
                                if (Key2.Key == ConsoleKey.D)
                                {
                                    NextKort2 = random.Next(1, 11);

                                    if (NextKort2 == 1)
                                    {
                                        if (Spillertal > 10)
                                        {
                                            NextKort2 = 1;
                                            Spillertal = Spillertal + NextKort2;
                                        }
                                        if (Spillertal <= 10)
                                        {
                                            NextKort2 = 11;
                                            Spillertal = Spillertal + NextKort2;
                                        }
                                    }
                                    else
                                    {
                                        Spillertal = Spillertal + NextKort2;
                                    }

                                    if (Spillertal > 21)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Du kom over 21 så du tabte");

                                        Console.WriteLine("Tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;

                                    }
                                    if (Spillertal == 21)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Du fik 21");

                                        Console.WriteLine("Tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;
                                    }
                                    if (Spillertal < 21)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Dealer har {0}", Dealerhånd);
                                        Console.WriteLine("Du fik {0}, så du har nu {1} ", NextKort2, Spillertal);

                                        Console.WriteLine("");
                                        Console.WriteLine("Tryk D for at trække et nyt kort");
                                        Console.WriteLine("Tryk G for at stå");

                                        ConsoleKeyInfo Key3 = Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        if (Key3.Key == ConsoleKey.G || Key3.Key == ConsoleKey.D)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("BlackJack");
                                        }
                                        if (Key3.Key == ConsoleKey.D)
                                        {
                                            NextKort3 = random.Next(1, 11);

                                            if (NextKort3 == 1)
                                            {
                                                if (Spillertal > 10)
                                                {
                                                    NextKort3 = 1;
                                                    Spillertal = Spillertal + NextKort3;
                                                }
                                                if (Spillertal <= 10)
                                                {
                                                    NextKort3 = 11;
                                                    Spillertal = Spillertal + NextKort3;
                                                }
                                            }
                                            else
                                            {
                                                Spillertal = Spillertal + NextKort3;
                                            }

                                            if (Spillertal > 21)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Du tabte, du fik {0} og kom over 21", Spillertal);
                                            }
                                            if (Spillertal == 21)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Du fik 21");
                                            }
                                            if (Spillertal < 21)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Du fik {0}, så du har nu {1} ", NextKort3, Spillertal);


                                            }
                                        }
                                        if (Key3.Key == ConsoleKey.G)
                                        {
                                            if (Dealerhånd < 17)
                                            {
                                                Dealerkort3 = random.Next(1, 11);

                                                if (Dealerkort3 == 1)
                                                {
                                                    if (Dealerhånd > 10)
                                                    {
                                                        Dealerkort3 = 1;
                                                        Dealerhånd = Dealerhånd + Dealerkort3;
                                                    }
                                                    if (Spillertal <= 10)
                                                    {
                                                        Dealerkort3 = 11;
                                                        Dealerhånd = Dealerhånd + Dealerkort3;
                                                    }
                                                }

                                                Dealerhånd = Dealerhånd + Dealerkort3;

                                                Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort3, Dealerhånd);
                                                if (Dealerhånd < 17)
                                                {
                                                    Dealerkort4 = random.Next(1, 11);

                                                    if (Dealerkort4 == 1)
                                                    {
                                                        if (Dealerhånd > 10)
                                                        {
                                                            Dealerkort4 = 1;
                                                            Dealerhånd = Dealerhånd + Dealerkort4;
                                                        }
                                                        if (Dealerhånd <= 10)
                                                        {
                                                            Dealerkort4 = 11;
                                                            Dealerhånd = Dealerhånd + Dealerkort4;
                                                        }
                                                    }

                                                    Dealerhånd = Dealerhånd + Dealerkort4;

                                                    Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort4, Dealerhånd);
                                                    if (Dealerhånd < 17)
                                                    {
                                                        Dealerkort5 = random.Next(1, 11);

                                                        if (Dealerkort5 == 1)
                                                        {
                                                            if (Dealerhånd > 10)
                                                            {
                                                                Dealerkort5 = 1;
                                                                Dealerhånd = Dealerhånd + Dealerkort5;
                                                            }
                                                            if (Dealerhånd <= 10)
                                                            {
                                                                Dealerkort5 = 11;
                                                                Dealerhånd = Dealerhånd + Dealerkort5;
                                                            }
                                                        }

                                                        Dealerhånd = Dealerhånd + Dealerkort5;

                                                        Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort5, Dealerhånd);
                                                    }
                                                }
                                            }
                                            if (Spillertal > 21)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Du fik {0} så du kom over 21", Spillertal);
                                                Console.WriteLine("");
                                                Console.WriteLine("Tryk på en knap for at spille igen");
                                                Console.ReadKey();
                                                ClearCurrentConsoleLine();
                                                Console.WriteLine("Vent venligst");
                                                Thread.Sleep(Sleep);
                                                goto Start;
                                            }
                                            if (Dealerhånd > Spillertal && Dealerhånd < 21)
                                            {
                                                Console.WriteLine("Dealer vandt, fordi dealer havde flest kort");
                                                Console.WriteLine("Tryk på en knap for at spille igen");
                                                Console.ReadKey();
                                                ClearCurrentConsoleLine();
                                                Console.WriteLine("Vent venligst");
                                                Thread.Sleep(Sleep);
                                                goto Start;
                                            }
                                            if (Spillertal == Dealerhånd)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Det stod lige");
                                                Console.WriteLine("Tryk på en knap for at spille igen");
                                                Console.ReadKey();
                                                ClearCurrentConsoleLine();
                                                Console.WriteLine("Vent venligst");
                                                Thread.Sleep(Sleep);
                                                goto Start;
                                            }
                                            if (Spillertal <= 21 || Spillertal > Dealerhånd)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Du vandt tryk på en knap for at spille igen");
                                                Console.ReadKey();
                                                ClearCurrentConsoleLine();
                                                Console.WriteLine("Vent venligst");
                                                Thread.Sleep(Sleep);
                                                goto Start;
                                            }

                                        }
                                    }
                                }
                                if (Key2.Key == ConsoleKey.G)
                                {
                                    if (Dealerhånd < 17)
                                    {
                                        Dealerkort3 = random.Next(1, 11);

                                        if (Dealerkort3 == 1)
                                        {
                                            if (Dealerhånd > 10)
                                            {
                                                Dealerkort3 = 1;
                                                Dealerhånd = Dealerhånd + Dealerkort3;
                                            }
                                            if (Spillertal <= 10)
                                            {
                                                Dealerkort3 = 11;
                                                Dealerhånd = Dealerhånd + Dealerkort3;
                                            }
                                        }

                                        Dealerhånd = Dealerhånd + Dealerkort3;

                                        Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort3, Dealerhånd);
                                        if (Dealerhånd < 17)
                                        {
                                            Dealerkort4 = random.Next(1, 11);

                                            if (Dealerkort4 == 1)
                                            {
                                                if (Dealerhånd > 10)
                                                {
                                                    Dealerkort4 = 1;
                                                    Dealerhånd = Dealerhånd + Dealerkort4;
                                                }
                                                if (Dealerhånd <= 10)
                                                {
                                                    Dealerkort4 = 11;
                                                    Dealerhånd = Dealerhånd + Dealerkort4;
                                                }
                                            }

                                            Dealerhånd = Dealerhånd + Dealerkort4;

                                            Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort4, Dealerhånd);
                                            if (Dealerhånd < 17)
                                            {
                                                Dealerkort5 = random.Next(1, 11);

                                                if (Dealerkort5 == 1)
                                                {
                                                    if (Dealerhånd > 10)
                                                    {
                                                        Dealerkort5 = 1;
                                                        Dealerhånd = Dealerhånd + Dealerkort5;
                                                    }
                                                    if (Dealerhånd <= 10)
                                                    {
                                                        Dealerkort5 = 11;
                                                        Dealerhånd = Dealerhånd + Dealerkort5;
                                                    }
                                                }

                                                Dealerhånd = Dealerhånd + Dealerkort5;

                                                Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort5, Dealerhånd);
                                            }
                                        }
                                    }
                                    if (Spillertal > 21)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Du fik {0} så du kom over 21", Spillertal);
                                        Console.WriteLine("Tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;
                                    }
                                    if (Dealerhånd > Spillertal && Dealerhånd < 21)
                                    {
                                        Console.WriteLine("Dealer vandt, fordi dealer havde flest kort");
                                        Console.WriteLine("Tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;
                                    }
                                    if (Spillertal == Dealerhånd)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Det stod lige");
                                        Console.WriteLine("Tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;
                                    }
                                    if (Spillertal <= 21 || Spillertal > Dealerhånd)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Du vandt tryk på en knap for at spille igen");
                                        Console.ReadKey();
                                        ClearCurrentConsoleLine();
                                        Console.WriteLine("Vent venligst");
                                        Thread.Sleep(Sleep);
                                        goto Start;
                                    }
                                }
                            }
                        }
                        if (Key1.Key == ConsoleKey.G)
                        {
                            if (Dealerhånd < 17)
                            {
                                Dealerkort3 = random.Next(1, 11);

                                if (Dealerkort3 == 1)
                                {
                                    if (Dealerhånd > 10)
                                    {
                                        Dealerkort3 = 1;
                                        Dealerhånd = Dealerhånd + Dealerkort3;
                                    }
                                    if (Spillertal <= 10)
                                    {
                                        Dealerkort3 = 11;
                                        Dealerhånd = Dealerhånd + Dealerkort3;
                                    }
                                }

                                Dealerhånd = Dealerhånd + Dealerkort3;

                                Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort3, Dealerhånd);
                                if (Dealerhånd < 17)
                                {
                                    Dealerkort4 = random.Next(1, 11);

                                    if (Dealerkort4 == 1)
                                    {
                                        if (Dealerhånd > 10)
                                        {
                                            Dealerkort4 = 1;
                                            Dealerhånd = Dealerhånd + Dealerkort4;
                                        }
                                        if (Dealerhånd <= 10)
                                        {
                                            Dealerkort4 = 11;
                                            Dealerhånd = Dealerhånd + Dealerkort4;
                                        }
                                    }

                                    Dealerhånd = Dealerhånd + Dealerkort4;

                                    Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort4, Dealerhånd);
                                    if (Dealerhånd < 17)
                                    {
                                        Dealerkort5 = random.Next(1, 11);

                                        if (Dealerkort5 == 1)
                                        {
                                            if (Dealerhånd > 10)
                                            {
                                                Dealerkort5 = 1;
                                                Dealerhånd = Dealerhånd + Dealerkort5;
                                            }
                                            if (Dealerhånd <= 10)
                                            {
                                                Dealerkort5 = 11;
                                                Dealerhånd = Dealerhånd + Dealerkort5;
                                            }
                                        }

                                        Dealerhånd = Dealerhånd + Dealerkort5;

                                        Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort5, Dealerhånd);
                                    }
                                }
                            }
                            if (Spillertal > 21)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du tabte");
                                Console.WriteLine("Tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                            if (Dealerhånd > Spillertal && Dealerhånd < 21)
                            {
                                Console.WriteLine("Dealer vandt, fordi dealer havde flest kort");
                                Console.WriteLine("Tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                            if (Spillertal == Dealerhånd)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Det stod lige");
                                Console.WriteLine("Tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                            if (Spillertal <= 21 || Spillertal > Dealerhånd)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du vandt tryk på en knap for at spille igen");
                                Console.ReadKey();
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Vent venligst");
                                Thread.Sleep(Sleep);
                                goto Start;
                            }
                        }
                    }
                }
                if (KeyInfo.Key == ConsoleKey.G)
                {
                    if (Dealerhånd < 17)
                    {
                        Dealerkort3 = random.Next(1, 11);

                        if (Dealerkort3 == 1)
                        {
                            if (Dealerhånd > 10)
                            {
                                Dealerkort3 = 1;
                                Dealerhånd = Dealerhånd + Dealerkort3;
                            }
                            if (Spillertal <= 10)
                            {
                                Dealerkort3 = 11;
                                Dealerhånd = Dealerhånd + Dealerkort3;
                            }
                        }

                        Dealerhånd = Dealerhånd + Dealerkort3;

                        Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort3, Dealerhånd);
                        if (Dealerhånd < 17)
                        {
                            Dealerkort4 = random.Next(1, 11);

                            if (Dealerkort4 == 1)
                            {
                                if (Dealerhånd > 10)
                                {
                                    Dealerkort4 = 1;
                                    Dealerhånd = Dealerhånd + Dealerkort4;
                                }
                                if (Dealerhånd <= 10)
                                {
                                    Dealerkort4 = 11;
                                    Dealerhånd = Dealerhånd + Dealerkort4;
                                }
                            }

                            Dealerhånd = Dealerhånd + Dealerkort4;

                            Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort4, Dealerhånd);
                            if (Dealerhånd < 17)
                            {
                                Dealerkort5 = random.Next(1, 11);

                                if (Dealerkort5 == 1)
                                {
                                    if (Dealerhånd > 10)
                                    {
                                        Dealerkort5 = 1;
                                        Dealerhånd = Dealerhånd + Dealerkort5;
                                    }
                                    if (Dealerhånd <= 10)
                                    {
                                        Dealerkort5 = 11;
                                        Dealerhånd = Dealerhånd + Dealerkort5;
                                    }
                                }

                                Dealerhånd = Dealerhånd + Dealerkort5;

                                Console.WriteLine("Dealer trak {0} og har nu {1}", Dealerkort5, Dealerhånd);
                            }
                        }
                    }
                    if (Spillertal > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du fik over 21 så du tabte, din hånd var {0}", Spillertal);
                        Console.WriteLine("Tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(Sleep);
                        goto Start;
                    }
                    if (Dealerhånd > Spillertal && Dealerhånd < 21)
                    {
                        Console.WriteLine("Dealer vandt, fordi dealer havde flest kort");
                        Console.WriteLine("Tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(Sleep);
                        goto Start;
                    }
                    if (Spillertal == Dealerhånd)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Det stod lige");
                        Console.WriteLine("Tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(Sleep);
                        goto Start;
                    }
                    if (Spillertal <= 21 || Spillertal > Dealerhånd)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du vandt tryk på en knap for at spille igen");
                        Console.ReadKey();
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Vent venligst");
                        Thread.Sleep(1000);
                        goto Start;
                    }

                }
                

            }

            Console.ReadKey();
        }
        public static void ClearCurrentConsoleLine()
        {
            // A void found on stackoverflow to clear the current line
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}