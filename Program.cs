namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region inkrementacja
            //int a = 0, b = 0, losowe = 0;
            //Random random = new Random();
            //int liczba = 0;
            //for (int i = 0; i < 100; i++)
            //    liczba++;
            //liczba--;
            //Console.WriteLine(liczba);
            //// for (START; WARUNEK KONCA; O ILE MA SIE ZMIENIAC)
            //for (int i = 0; i < 100; i++)
            //{
            //    losowe = random.Next(101);
            //    if (losowe % 4 == 0)
            //        a++;
            //    else if (losowe % 4 == 1)
            //    {
            //        a++;
            //        b--;
            //    }
            //    else if (losowe % 4 == 2)
            //    {
            //        a--;
            //        b++;
            //    }
            //    else
            //        b++;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            //#region if elsy
            //double jpolski, matematyka, jangielski, WF, Historia, wynik;
            //bool flaga = true;
            //string znak ="";
            //while (flaga) 
            //{ 
            //    Console.WriteLine("Podaj ocene z polskiego: ");
            //    jpolski = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Podaj ocene z matematyka: ");
            //    matematyka = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Podaj ocene z angielskiego: ");
            //    jangielski = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Podaj ocene z wf: ");
            //    WF = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Podaj ocene z historii: ");
            //    Historia = double.Parse(Console.ReadLine());
            //    wynik = (jpolski + matematyka + jangielski + WF + Historia) / 5;
            //    Console.WriteLine($"Twoja średnia to: {Math.Round(wynik, 2)}");
            //    if (wynik >= 4.75)
            //        Console.WriteLine("Masz pasek gratuluje!");
            //    else
            //        Console.WriteLine("Brak paska, smutek");
            //    Console.WriteLine("Czy chcesz kontynuuować? T/N");
            //    znak = Console.ReadLine();
            //    if (znak == "T")
            //        continue;
            //    else
            //        flaga = false;
            //}



            int liczbaGracza, ileDodajemy, oczko,runda = 1, liczbaBota,ileDodajemyBot;
            Random rand = new Random();
            oczko = 21;
            bool flaga = true;
            bool gra = true;
            string wybor, kontynuacja;
            while(flaga)
            {
                gra = true;
                liczbaGracza = rand.Next(1,12);
                liczbaBota = rand.Next(1,12);
                while(gra)
                {
                    Console.WriteLine($"Runda {runda}");
                    Console.WriteLine($"Twoje punkty: {liczbaGracza}");
                    Console.WriteLine("Czy grasz dalej? T/N");
                    wybor = Console.ReadLine();
                    if( wybor.ToUpper() == "T")
                    {
                        runda++;
                        ileDodajemy = rand.Next(1, 12);
                        liczbaGracza += ileDodajemy;

                        if (liczbaGracza > oczko)
                        {
                            Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
                            Console.WriteLine($"Punkty Bota: {liczbaBota}");
                            Console.WriteLine("Bardzo się starałeś ,lecz z gry wyleciałeś");
                            gra = false;
                        }
                        else if(liczbaGracza == oczko)
                        {
                            Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
                            Console.WriteLine($"Punkty Bota: {liczbaBota}");
                            Console.WriteLine("OCZKO, wygrałeś!");
                            gra = false;
                        }


                        ileDodajemyBot = rand.Next(1, 12);
                        liczbaBota += ileDodajemyBot;
                        if(liczbaBota > oczko)
                        {
                            Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
                            Console.WriteLine($"Punkty Bota: {liczbaBota}");
                            Console.WriteLine("Gracz wygrał!");
                            gra = false;
                        }
                        else if (liczbaBota == oczko)
                        {
                            Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
                            Console.WriteLine($"Punkty Bota: {liczbaBota}");
                            Console.WriteLine("OCZKO,Bot wygrał!");
                            gra = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Masz {liczbaGracza} punktow");
                        Console.WriteLine($"Bot ma {liczbaBota} punktow");
                        if (liczbaBota > liczbaGracza) 
                        {
                            Console.WriteLine("Bot wygrał");
                        }
                        else 
                        {
                            Console.WriteLine("Gracz wygrał");
                        }
                        gra = false;
                    }
                }
                Console.WriteLine("Czy chcesz grać dalej? T/N");
                kontynuacja = Console.ReadLine();
                if (kontynuacja.ToUpper() == "N")
                    flaga = false;
            }
        }
    }
}