namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");

            ////Muutujad, Matemaatilised tehted, IF, ESLE IF ja ELSE:

            ////1. tuvasta sisu võrdluses null'ga
            //Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            //string nimi = Console.ReadLine();

            //if (nimi == "")
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}
            //else if (nimi != "")
            //{
            //    Console.WriteLine("Tere " + nimi + "!");
            //}
            //else
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}

            ////2. tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            //Console.WriteLine(nimi + ", mis on sinu vanus?");
            //int kasutajavanus = int.Parse(Console.ReadLine());
            ////2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0 && kasutajavanus <18)
            //{
            //Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😭");
            //}
            //else
            //{
            //    Console.WriteLine("Saad osta Monsterist, YAYY!!!");
            //}

            ////2.2 Mitu tingimust ühe ifi sees kasutades loogilist tehet "and", välitides pesastamist
            //if (kasutajavanus > 0 && kasutajavanus < 10)
            //{
            //    if (kasutajavanus < 10)
            //        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma((");
            //}
            ////2.3 mitu vahemiku, if-elseif abil, double/float
            //Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
            //double pikkus = double.Parse(Console.ReadLine());
            //if (pikkus < 1.00d)
            //{
            //    Console.WriteLine("Oled juntsu ");
            //}
            //else if (pikkus < 1.25d && pikkus > 1.00d)
            //{
            //    Console.WriteLine("Oled peaaegu allameetrimees");
            //}
            //else if (pikkus < 1.50d && pikkus > 1.25d)
            //{
            //    Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            //}
            //else if (pikkus < 1.75 && pikkus > 1.5d)
            //{
            //    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö ");
            //}
            //else if (pikkus > 2.00d && pikkus > 1.75d)
            //{
            //    Console.WriteLine("Oioi, päkapikk enam ei olegi ");
            //}
            //else if (pikkus > 2.00d)
            //{
            //    Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad");
            //}
            //else
            //{
            //    Console.WriteLine("Pikkust ei tunta");
            //}

         
            //Kalkulatoor!!!

            //Console.WriteLine("Tere, sisesta esimene arv");
            //Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgde vahel
            //ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta esimene arv".
            //Lause lõppeb lauselõppemärgiga ";".

            //int arv1 = int.Parse(Console.ReadLine());
            //instantieerime muutuja nimega "arv1", ning selle ette aname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresserime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsurepealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõppemärgiga ";".

            //Console.WriteLine("Sisesta teine arv");
            //Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgde vahel
            //ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause lõppeb lauselõppemärgiga ";".

            //int arv2 = int.Parse(Console.ReadLine());
            //instantieerime muutuja nimega "arv2", ning selle ette aname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresserime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsurepealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõppemärgiga ";".

            //Console.WriteLine("Sisesta tehemärk: / * + - ^ ");
            //Aadresserime moodulit "Console" koos "WriteLine" funktsiooniga, et esitada kasutajale
            //küsimuse "Sisesta tehemärk: / * + - ^ ". Punkti abil saame moodulist Console, funktsiooni
            //WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            //jutumärkidega. Lause lõppeb lauselõppemärgiga ";".

            //string tehtetyyp = Console.ReadLine();
            //instatsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string".
            //Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            //"Console" moodulis oleva ReadLine() funktsiooni abil. Lause lõppeb lauselõppemärgiga ";".

            //int tulemus = 0;
            //instantseerime muutja nimega "tulemus", andmetüübiga int, ning omistame talle algse
            //väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõppemärgiga ";".

            //if (tehtetyyp == "+")
                //teeme tingimuslause if,ning selle tingimuse määrame ära sulgudega, mille vahel on
                //võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
                //nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
                //ole koodiga mis midagi kindlalt veel ära teeb.
            //{
            //    tulemus = arv1 + arv2;
            //}
            //peale tingimust on koodiplokk {} sulgude vahel, mis sisaldab endas ühte koodirida.
            //selle lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            //kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõppemärgiga ";".

            //else if (tehtetyyp == "-")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 - arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            //oleva väärtuse. Lause lõppeb lauselõppemärgiga ";".

            //else if (tehtetyyp == "/")
            //teeme sekundarse tingimuslause "else if2, ning määrassme tema tingimuse ära sulgudega.
            //Sulgude vahel on võrduskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus ei täitunud
            //Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 / arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tullemuse, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga
            //Lause lõppeb lauselõppemärgiga ";".

            //else if (tehtetyyp == "*")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
            //täitnud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.

            //{
            //    tulemus = arv1 * arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutjale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus korrutame muutujas "arv2" oleva väärtuse muutjas "arv1" oleva väärtuse
            //kordi. Lause lõppeb lauselõppemärgiga ";".

            //else if (tehtetyyp == "^")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgud vahel on võrdsuskontoll, kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "^" kul eelnev tingimus ei
            //täitnud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //kooditida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
            //"Math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetrina
            //sisse muutjad "arv1" ja "arv2". Esimene parameeter on astendatav, teine paraameter
            //on asendaja. Funktsiooni Math.Pow() ees on kiirtesendus (int), kuna muutuja
            //"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks.
            //Lause lõppeb lauselõppemärgiga ";".

            //else
            //pealekõiki järeltingimusi on meil tingimuslause ose "else" mida täedatakse kõikide muude
            //tingimuslause osage miitetätumisel. Siin eraldi tingimust välja ei kirjutada
            //ning sellest tulenevalt ei ole ka sulge. Järgneb ainult koodiplokk-
            //{
            //    Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
            //}
            //pelse "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles koodireas kasutame moodulist "Console" punkti abil funktsiooni
            //"WriteLine" et öelda kasutajale "Palun sisesta tehe, mida kalkulaator tuvastada
            //oskab". Koodirida lõppeb lauselõppemärgiga ";".

            //Console.WriteLine(tulemus);
            //Kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisedamata. Lause lõppeb lauselõppemärgiga ";".

            //Console.WriteLine("Kas sa tahad õuna või banaani?");
            //string vastus = Console.ReadLine();
            //if (vastus == "õuna")
            //{
            //    Console.WriteLine("õun, palun 🍎🍏");
            //}
            //else if (vastus == "banaani")
            //{
            //    Console.WriteLine("banaani, palun🍌🍌");
            //}
            //else
            //{
            //    Console.WriteLine("Sellist puuvilja ma ei tunne");
            //}
            //;


            Console.WriteLine("hapukapsas");
            // "Console"        - see on moodul C# mida me adresserim, Consle aitab teha tegevusi käsureal
            // .                - näitab, et meil on vaja adresserida mingisugust funktsiooni või meetodit mooduli "Console" seest.
            // "WriteLine"      - Funktsioon mida me parasjage kasutame.
            // ()               - sulupaar mis omab funktsiooni tööks vajalikku infot
            // []               - tähistab massiive
            // {}               - koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või funktsiooni kirjeldust
            // "hapukapsas"     - parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa
            //                  - Taane aitab arendajal aru saada, kuskohas millise koodiplokki sees kood asub, see on vajalik ka komplaatorile samal eesmärgil
            // ;                - kõik koodilaused lõppevad komakooloniga, mis tähistavad lause lõppu
            // //               - tähistab üherealist kommetaari
            // /**/             - tähistab mitmerealist kommentaari või kommentariregiooni

            int muutuja = 3;
            // int              - see on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist tüüpi andmed selle muutuja sees on
            // "muutuja"        - on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava sõnaga, ja mille abil saab neid adresserida koodi sees
            // =                - üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub teiselpool võrdusmärki.
            // 3                - muutujale omistatav väärtus.

            /* Võimalikud andmetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M;   // decimal on kümnendsüsteemis olev komakohaga arv
            float c = 3.9f;     // float on 32-bitine komakohaga arv
            double d = 5.6d;    // double on 64-bitine komakohaga arv
            char c1 = 'a';     // üksainus täht või tähemark mis asub ülakomade vahel ''
            string s = "tekst"; // tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "abc";      // var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;        // ta võib omada endas teisi andmetüppe
            const int z = 9;    //konstanttüüpi muutujad ei saa muuta, nende sisu on read-only

            //põhilised matemaatilised tehted
            int liitmine = 1 + 1; // liitmine, kaks arvu liidetakse (сложение)
            int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine (вычитание)
            double korrutamine = 1 * 2; //korrutamine, kus eine arv korrutatakse esimese arvu kordi (умножение)
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga (деление)
            double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
            double juurimine = Math.Sqrt(2); // ruutjuur, parameetrina juuritav arv

            //muutuja nimed
            int arv = 0;
            string sõne = "abc";
            //string string = "abc"; kaitstud sõna kasutada ei saa

            // muutuja nime ei sobi järgnevad sõnad:
            // abstract, as, base, bool, break, byte, case
            // catch, char, checked, class, count, continue, decimal,
            // default, delegate, do, double, else, enum, event,
            // explicit, extern, false, finally, fixed, float, for,
            // foreach, goto, if, implicit, in, int, imterface, internal
            // is, lock, long, namespace, new, null, object, operator,
            // out, override, params, private, protected, public, readonly,
            // ref, return, sbyte, sealed, short, sizeof, stackalloc,
            // static, string, struct, switch, this, throw, try, typeof, uint
            // ulong, unchekced, unsafe, ushort, using, virtual, void, volatile, while.

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust!");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestanud vigane arv");
            }

            //string kasutajanimi = "";
            //do
            //{
            //    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
            //    kasutajanimi = Console.ReadLine();
            //} while (kasutajanimi != "user1");
            //if (kasutajanimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruutu saada tahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

            //    char reaKujund = '▓';
            //    string üksRida = "";
            //    int tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        üksRida = üksRida + "_" + reaKujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //}

            /* tingimuslause osad */
            if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
            //koodiplokk tingimuse täitumisel teostatava koodiga

            else if (true) { } //käitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
            //on samamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if". Tingimuse täitumisel
            //ja eelneva tingimuse mittetäitumisel, teostatakse koodiplokki sees olev kood.

            else { } //käitastud sõna else kutsub esile järeltingimuse, millele peab eelenema kas "if" või "else if", ning mille koodiplokki sisu
                     //täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel.

            int option = 3; // --------
            switch (option) // "switch on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab ef else-if asemel kasutdada.
                            //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
                            //ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
                            //pärast lülitusvalikut tuleb koodiplokk.
            {
                case 1:     //koodiplokki sees on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse,
                            //kas muutujas "option" on väärtus 1, millele järgned koolon ":" väljendades tingimuse täitumisel tehtava
                            //kooditegevuse algust
                    break;      //Kui tegevus on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingimustikust käitstud
                                //sõnaga "break". Peale breaki on lauselõpemärk ";".
                case 2:         //Juhtmeid võib olla mitmeid, antud juhul on neid kolm kindlalt.
                    break;
                case 3:
                    Console.WriteLine(option); //tehtav kooditegevus.
                    break;
                default:    //Default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;  //Ka default lõppeb sõnaga break.
            }

            /* sõne tööriistad ja muud tekstiga seotut */
            string alfa = "a\nb";         // \nb -> tekitab ühe sõne sisse reamurde, sõne kus on sees "\n", omab kahte rida.
            string beta = $"a {alfa} b";  // $ -> lubab kasutada muutjaid loogeliste sulgudega otse teksti sees. On variant
                                          //      formateeritud stringist.


            /* Loogilised tehted */

            // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivs vastuse (true) juhul kui
            //       mõlemal pool "&&" märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
            //       vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
            // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks (true),
            //       hüümärgi abil tagastab (false), ja vastupidi - tulemus mis muidu tagastaks (false, hüümärgi abil tagastab (true)

            /* Võrdlusoperaatorid */

            // == -> "on võrdne". Võrdusmärkide ühel pool olev objekt peab astama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //       objektiga. ei ole sama naga üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //       Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul. Võrdlusoperaator on kombinatsioon
            //       "on võrdne operaatorist, ja loogilisest tehtest "not".
            // >  -> "on suurem kui". Märgist vasakul pool olev objekty peaks olema suurem, kui paremal pool olev objekt.
            // <  -> "on väiksem kui". Märgist vasakul pool olev objekty peaks olema suurem, kui paremal pool olev objekt.
            // >= -> "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            //       Võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            // <= -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parempoolne objekt.
            //       Võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

            /* omastusoperaatorid ja kiirtehted */

            int thing = 1; // = -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada, läbi muutuja nime.
            thing += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                          //       asendab tehet "thing = thing + 1". on kombinatsioon atemaatiliselt tehtest "+" ja omistamisest "=".
            thing -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutjast maha võrdusmärgi teisel pool oleva arvu.
                          //       asendab tehet "thing = thing - 1". on kombinatsioon matemaatiliselt tehtest "-" ja omistamisest "=".
            thing *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                          //       oleva arvu kordi. asendab tehet "thing = thing * 2". on kombinatsioon matemaatilisest tehtest "*" ja
                          //       omistamisest "=".
            thing /= 2;   // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                          //       arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest "=".
            thing++;      //       on spetsiifiliselt ühe juurde liitmiseksgggggggggg kiirtehe.
            thing--;      //       on spetsiifiliselt ühe maha lahutamiseks kiirtehe.

            /* Tsükilid */
            // 1. do while
            int dew = 0;
            do // "do" on käitstud sõna, mis alustab dó-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi
            {
                dew++;
            } while (dew != 5); // niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.

            // 2. while
            int i = 1;      //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel
            while (i < 5);  //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist
                            //tsüklimuutujat. Antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel,
                            //siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                            // antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel katkeb
            {
                //koodiplokk kus midagi tehakse
                i++;        //ning seejärel muudetakse tsüklimuutuja "i" olekut. Antud juhul liidetakse 1 juurde kiirtehtega "++".
            namespace Eelarve_Arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt tema nime (tsüklis)
            string kasutajaNimi = "";
            while (kasutajaNimi == "")
            {
                Console.WriteLine("Tere, sisesta oma nimi:");
                kasutajaNimi = Console.ReadLine();
            }

            //küsi kasutajalt tema tulusid, niikaua kuni rohkem pole
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rohkem pole.
            //hoia andmeid List tüüpi muutujas, andmed ise peavad olema komakohaga.
            string sisestus = "";
            Console.WriteLine("Sisesta tulud ükshaaval, kui on kõik, siis kirjuta \"rohkem pole\"");
            List<float> tulud = VõtaKasutajaltMituSisenditJärjest();
            Console.WriteLine("Sisesta OMA KULUD ükshaaval, kui on kõik, siis kirjuta \"rohkem pole\"");
            List<float> kulud = VõtaKasutajaltMituSisenditJärjest();

            //tee uus meetod, mis arvutab kokku järjendi sisu

            float tuludkokku = 0;
            tuludkokku = ArvutaKokku(tulud);
            float kuludkokku = ArvutaKokku(kulud);

            //hoia kogutulusid ja kogukulusid eraldi muutujates kasutades oma meetodit.

            //arvuta kasutajale tulude ja kulude põhjal tema hetkeseis.
            float kokku = (float)Math.Round((tuludkokku - kuludkokku),2);
            //ümarda kasutajale tagastatav arv kahe komakohani. Ja kuva nimeline sõnum
            Console.WriteLine($"Kasutaja: {kasutajaNimi}, teie kontoseis on: {kokku}");
        }
        private static float ArvutaKokku(List<float> tulud)
        {
            float kokku = 0;
            for (int i = 0; i < tulud.Count; i++)
            {
                kokku += tulud[i];
            }

            return kokku;
        }

        private static List<float> VõtaKasutajaltMituSisenditJärjest()
        {
            List<float> tulud = new List<float>();
            string sisestus;
            do
            {
                Console.WriteLine("Sisesta oma andmed *ÜKSHAAVAL* - järgmine sisestus:");
                sisestus = Console.ReadLine();
                if (sisestus == "rohkem pole")
                {
                    break;
                }
                float conversion = float.Parse(sisestus);
                tulud.Add(conversion);
            } while (sisestus != "rohkem pole");
            return tulud;
        }
    }
}
