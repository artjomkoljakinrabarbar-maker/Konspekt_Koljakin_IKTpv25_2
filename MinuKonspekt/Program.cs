namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Muutujad, Matemaatilised tehted, IF, ESLE IF ja ELSE:

            //1. tuvasta sisu võrdluses null'ga
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            //2. tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ", mis on sinu vanus?");
            int kasutajavanus = int.Parse(Console.ReadLine());
            //2.1 mitu tingimust pesastatud if-ide abil
            if (kasutajavanus > 0 && kasutajavanus <18)
            {
            Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😭");
            }
            else
            {
                Console.WriteLine("Saad osta Monsterist, YAYY!!!");
            }

            //2.2 Mitu tingimust ühe ifi sees kasutades loogilist tehet "and", välitides pesastamist
            if (kasutajavanus > 0 && kasutajavanus < 10)
            {
                if (kasutajavanus < 10)
                    Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma((");
            }
            //2.3 mitu vahemiku, if-elseif abil, double/float
            Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oled juntsu ");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
            {
                Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 1.75 && pikkus > 1.5d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö ");
            }
            else if (pikkus > 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Oioi, päkapikk enam ei olegi ");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad");
            }
            else
            {
                Console.WriteLine("Pikkust ei tunta");
            }

            Console.WriteLine("tere, sisesta liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, sisesta liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("palun sisesta tehemärk: / * + - ^ ");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;

            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;
            }

            else if (tehtetyyp == "-")

            {
                tulemus = arv1 - arv2;
            }

            else if (tehtetyyp == "*")
            {
                tulemus = arv1 * arv2;
            }

            else if (tehtetyyp == "/")
            {
                tulemus = arv1 / arv2;
            }

            else if (tehtetyyp == "^")
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            else
            {
                Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
            }
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            }

            Console.WriteLine("Kas sa tahad õuna või banaani?");
            string vastus = Console.ReadLine();
            if (vastus == "õuna")
            {
                Console.WriteLine("õun, palun 🍎🍏");
            }
            else if (vastus == "banaani")
            {
                Console.WriteLine("banaani, palun🍌🍌");
            }
            else
            {
                Console.WriteLine("Sellist puuvilja ma ei tunne");
            }
            ;





        }
    }
}
