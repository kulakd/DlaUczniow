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

            //int liczbaGracza, ileDodajemy, oczko, runda = 1, liczbaBota, ileDodajemyBot;
            //Random rand = new Random();
            //oczko = 21;
            //bool flaga = true;
            //bool gra = true;
            //string wybor, kontynuacja;
            //while (flaga)
            //{
            //    gra = true;
            //    liczbaGracza = rand.Next(1, 12);
            //    liczbaBota = rand.Next(1, 12);
            //    while (gra)
            //    {
            //        Console.WriteLine($"Runda {runda}");
            //        Console.WriteLine($"Twoje punkty: {liczbaGracza}");
            //        Console.WriteLine("Czy grasz dalej? T/N");
            //        wybor = Console.ReadLine();
            //        if (wybor.ToUpper() == "T")
            //        {
            //            runda++;
            //            ileDodajemy = rand.Next(1, 12);
            //            liczbaGracza += ileDodajemy;

            //            if (liczbaGracza > oczko)
            //            {
            //                Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
            //                Console.WriteLine($"Punkty Bota: {liczbaBota}");
            //                Console.WriteLine("Bardzo się starałeś ,lecz z gry wyleciałeś");
            //                gra = false;
            //            }
            //            else if (liczbaGracza == oczko)
            //            {
            //                Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
            //                Console.WriteLine($"Punkty Bota: {liczbaBota}");
            //                Console.WriteLine("OCZKO, wygrałeś!");
            //                gra = false;
            //            }


            //            ileDodajemyBot = rand.Next(1, 12);
            //            liczbaBota += ileDodajemyBot;
            //            if (liczbaBota > oczko)
            //            {
            //                Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
            //                Console.WriteLine($"Punkty Bota: {liczbaBota}");
            //                Console.WriteLine("Gracz wygrał!");
            //                gra = false;
            //            }
            //            else if (liczbaBota == oczko)
            //            {
            //                Console.WriteLine($"Punkty Gracza: {liczbaGracza}");
            //                Console.WriteLine($"Punkty Bota: {liczbaBota}");
            //                Console.WriteLine("OCZKO,Bot wygrał!");
            //                gra = false;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Masz {liczbaGracza} punktow");
            //            Console.WriteLine($"Bot ma {liczbaBota} punktow");
            //            if (liczbaBota > liczbaGracza)
            //            {
            //                Console.WriteLine("Bot wygrał");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Gracz wygrał");
            //            }
            //            gra = false;
            //        }
            //    }
            //    Console.WriteLine("Czy chcesz grać dalej? T/N");
            //    kontynuacja = Console.ReadLine();
            //    if (kontynuacja.ToUpper() == "N")
            //        flaga = false;
            //}


            //int liczba = 0;
            //bool flaga = true;
            //Random r = new Random();
            //int watch = 0;
            //while (flaga)
            //{
            //    if (watch != 3)
            //    {
            //        liczba = r.Next(1, 4);
            //        switch (liczba)
            //        {
            //            case 0:
            //                Console.WriteLine(0);
            //                break;
            //            case 1:
            //                Console.WriteLine(1);
            //                break;
            //            case 2:
            //                Console.WriteLine(2);
            //                break;
            //            case 3:
            //                Console.WriteLine(3);
            //                break;
            //            case 4:
            //                Console.WriteLine(4);
            //                break;
            //            case 5:
            //            case 6:
            //                Console.WriteLine("Skibidi");
            //                break;
            //            default:
            //                Console.WriteLine("Beta");
            //                watch++;
            //                break;
            //        }
            //    }
            //    else
            //        flaga = false;

            //    //    if (liczba == 1)
            //    //        Console.WriteLine("1");
            //    //    else if (liczba == 2)
            //    //        Console.WriteLine("2");
            //    //    else if (liczba == 3)
            //    //        Console.WriteLine("3");
            //    //    else if (liczba == 4)
            //    //        Console.WriteLine("4");
            //    //    else
            //    //    {
            //    //        Console.WriteLine("Theta");
            //    //        flaga = false;
            //    //    }
            //}

            char znak;
            double l1, l2;
            bool flaga = true;
            while (flaga)
            {
                Console.WriteLine("Wybierz operacje:");
                Console.WriteLine("+. Dodawanie");
                Console.WriteLine("-. Odejmowanie");
                Console.WriteLine("*. Mnożenie");
                Console.WriteLine("/. Dzielenie");
                znak = char.Parse(Console.ReadLine());
                switch(znak) 
                {
                    case '+':
                        Console.WriteLine("Podaj pierwsza liczbę: ");
                        l1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę: ");
                        l2 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Wynik: {l1} + {l2} = {l1 + l2}");
                        break;
                    case '-':

                    default:
                        Console.WriteLine("Podaj poprawną operację");
                        break;
                }
            }
        }
    }
}