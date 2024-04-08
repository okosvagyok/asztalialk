/* DateTime struktúra valósítja meg, ez mindig a valós idő egy adott pillanatát tárolja
A DateTime típusú változó értéke: 1.01.01. 00:00:00 - 9999.12.31. 23:59:59
Dátum és idő megadása:
    DateTime csakdatum = new DateTime(2023, 5, 3)
    DateTime mindketto = new DateTime(2023, 5, 3, 8, 0, 0)
év, hónap, nap, óra, perc, másodperc - egész típusúak

Eltelt idő tárolása
TimeSpan struktúra valósítja meg
Pl. TimeSpan elteltido = new TimeSpan(2, 10, 30);
            2 óra 10 perc 30 másodperc
TimeSpan elteltDatumIdo = new TimeSpan(1, 2, 10, 30);
            1 nap 2 óra 10 perc 30 másodperc

Pl. Hány nap van Karácsonyig?
DateTime d1 = new DateTime(2023,12,24);
DateTime aktualisIdo = DateTime.Now;
TimeSpan elteltIdo = d1-aktualisIdo; //TimeSpan elteltido = d1.Subtract(aktualisIdo);
Console.WriteLine(elteltido.Days.Tostring()); //napokban kiírva


DateTime tulajdonságok és metódusok
Aktuális dátum: Now tulajdonság
    DateTime aktualisIdo = DateTime.Now;
Month, Day tulajdonságok
    DateTime d1 = new DateTime(2023, 12, 24);
    int honap = d1.Month; //12
    int nap = d1.Day; //24
Year, Hour, Minute, Second tulajdonságok
DayOfWeek, DayOfYear tulajdonságok
    ToString()-gel kiiratva a nap angol nevét, int-é konvertálva a nap sorszámát kapjuk meg
    pl. DateTime d1 = new DateTime(2023, 12, 24);
        label1.Text = d1.DayOfWeek.ToString(); // Sunday
        int hetnapja = (int) d1.DayOfWeek; // 7
IsLeapYear metódus
    DateTime d1 = new DateTime(2023, 12, 24);
    int ev = d1.Year;
    if (DateTime.IsLeapYear(ev))
    {
        label1.Text = "Szökőév";
    }
    else
    {
        label1.Text = "Nem szökőév";
    }
2 dátum összehasonlítása: Compare metódus
    if (DateTime.Compare(d1, d2) < 0)
    {
        label1.Text = "d1 a korábbi dátum";
    }
    elseif (DateTime.Compare (d1, d2) == 0)
    {
        label1.Text = "A két dátum megegyezik";
    }
    else
    {
        label1.Text = "d1 a későbbi dátum";
    }
AddDays, AddHours metódus
    pl. DateTime d1 = new DateTime(2023, 12, 24, 20, 0, 0);
    DateTime d2 = d1.AddDays(7);
    DateTime d3 = d1.AddHours(3);
Használhatunk AddMonths, AddSeconds, stb. metódusokat is

Dátum és idő megjelenítése
    pl. DateTime d1 = new DateTime(2023, 12, 24, 16, 2, 15, 23);
    label1.Text = d1.ToString("yy/M/d"); //23.12.24.
    label1.Text = d1.ToString("yyyy/MMM d ddd"); //2023.dec.24. Vas
    label1.Text = d1.ToString("HH:mm:ss") //16:02:15
    label1.Text = d1.ToString("HH:mm:ss.fff"); //16:02:15.023
label1.Text = d1.ToString("T");
szöveg konvertálása DateTime típusra:
string szovegesdatum = "2016.12.24.";
DateTime datum = DateTime.Parse(szovegesdatum);


//Hány nap van az érettségiig?
DateTime d1 = new DateTime(2024, 5, 6, 8, 0, 0);
DateTime d2 = DateTime.Now;
TimeSpan d3 = d1 - d2;
Console.WriteLine($"Az érettségiig hátravan még {d3.Days} nap, {d3.Hours} óra, {d3.Minutes} perc és {d3.Seconds} másodperc.");

//Milyen idős vagyok
DateTime s1 = new DateTime(2005, 4, 8);
DateTime s2 = DateTime.Now;
TimeSpan s3 = s2 - s1;
Console.WriteLine($"Én {s3.Days/365} éves, {s3.Days/365*12} hónapos és {s3.Days} napos vagyok.");

//Milyen napra esik a dátum?
Console.Write("Kérek egy dátumot: ");
string date = Console.ReadLine();
DateTime datum = DateTime.Parse(date);
Console.WriteLine($"A megadott dátum ({date}) {datum.ToString("dddd")} napra esik.");
*/

/*
Típuskonverziók
Implicit (automatikus):
	pl. double d=12; //12.0
	pl. int i=13.5 //adatvesztés lenne, nem működik
Explicit (mi adjuk meg, hogy milyen típusra konvertálja)
	tipus.Parse(string típusú változó) //csak stringből (beolvasáskor ajánlott)
	pl. string beker = Console.ReadLine();
		int szam1 = int.Parse(beker);
	Convert.To+típus(bármilyen típus)
	pl. int szam2 = Convert.ToInt32(beker);
	típuskényszerítés (castolás)
	pl. double hanyados = (double)szam1/szam2;

is és as operátorok:
    is-t típusok futásidejű lekérdezésére használjuk
        pl. if(obj is Jedi) .../if (obj is Uralkodo) ...
    as az ellenőrzés mellett egy explicit típuskonverziót is végrehajt
    pl. class Negyzet
    {
        public int Aoldal;
    }
    class Teglalap : Negyzet
    {
        public int Boldal;
    }
    public void Akarmi (Negyzet n)
    {
        if (n is Teglalap)
        {
            (n as Teglalap).Boldal = 20;
        }
    }
Karakterkonverziók:
A char típust implicit módon tudjuk numerikus típusra konvertálni, ekkor a karakter Unicode értékét kapjuk vissza.
pl. char c = "a";
    int x = c;
    Console.WriteLine(x); //97
    int y = 100;
    char c2 = (char)y;
    Console.WriteLine(c2) //d

*/

/*
//Osztálypénz feladat
Random r = new Random();
List<Tanulo> tanulok = new List<Tanulo>();
int letszam = r.Next(5, 16);
for(int i = 0; i<letszam; i++)
{
    tanulok.Add(new Tanulo(i+1));
}

for(int i = 0; i < letszam; i++)
{
    for(int j = 0; j < 10; j++)
    {
        DateTime jelenlegiDatum = new DateTime(2023,09,01).AddMonths(j);
        DateTime datum2 = jelenlegiDatum.AddMonths(1);
        int napok = DateTime.DaysInMonth(datum2.Year, datum2.Month);
        DateTime datum3 = datum2.AddDays(r.Next(1, napok+1));
        datum2 = datum2.AddDays(r.Next(1, napok + 1));
        tanulok[i].tranzakciok.Add(new Befizetes(datum2, "osztalypenz", r.Next(1, 10) < 3? 1000*r.Next(1,10):1000));
        tanulok[i].tranzakciok.Add(new Befizetes(datum3, "kozoskoltseg", r.Next(2000, 5001) / letszam*(-1)));
        tanulok[i].egyenleg += r.Next(2000, 5001) / letszam * (-1)+ r.Next(1, 10) < 3 ? 1000 * r.Next(1, 10) : 1000;
    }
    int alkalom = r.Next(1, 4);
    DateTime kezdo = new DateTime(2023, 09, 01);
    for (int k = 0; k < alkalom; k++)
    {
        kezdo = kezdo.AddMonths(r.Next(1, 11)).AddDays(r.Next(1, 28));
        tanulok[i].tranzakciok.Add(new Befizetes(kezdo, "egyedikoltseg", r.Next(1000, 1501) / letszam * (-1)));
        tanulok[i].egyenleg += r.Next(1000, 1501) / letszam * (-1);
    }
}

for(int i = 0; i < letszam; i++)
{
    Console.WriteLine($"Tanuló sorszáma: {tanulok[i].sorszam}/{letszam}");
    Console.WriteLine($"Nyitóegyenleg: {tanulok[i].kezdoegyenleg}");
    List<Befizetes> sort = tanulok[i].tranzakciok.OrderBy(x => x.datum).ToList();
    for(int j = 0; j < sort.Count; j++)
    {
        Console.WriteLine($"{sort[j].datum}, {sort[j].jelleg}, {sort[j].osszeg}");
    }
    Console.WriteLine($"Záróegyenleg: {tanulok[i].egyenleg}");
}

class Tanulo
{
    public int sorszam;
    public int kezdoegyenleg;
    public int egyenleg;
    Random rnd = new Random();
    public List<Befizetes> tranzakciok;

    public Tanulo(int sorszam)
    {
        this.sorszam = sorszam;
        this.kezdoegyenleg = rnd.Next(1000, 3501);
        this.tranzakciok = new List<Befizetes>();
    }
}

class Befizetes
{
    public DateTime datum;
    public string jelleg;
    public int osszeg;

    public Befizetes(DateTime datum, string jelleg, int osszeg)
    {
        this.datum = datum;
        this.jelleg = jelleg;
        this.osszeg = osszeg;
    }
}
*/

/*
//Egyszámjáték
StreamReader f = new StreamReader("egyszamjatek.txt");
List<jatekosok> jatek = new List<jatekosok>();
List<int> Pontszam = new List<int>();
while (!f.EndOfStream)
{
    string[] line = f.ReadLine().Split(" ");
    Pontszam = new List<int>();
    for (int i = 0; i < line.Length - 1; i++)
        Pontszam.Add(int.Parse(line[i]));
    jatek.Add(new jatekosok(line[line.Length - 1], Pontszam));
}
Console.WriteLine($"3. feladat: Ennyi játékos vett részt: {jatek.Count}");
Console.WriteLine($"4. feladat: Ennyi fordulót játszottak: {Pontszam.Count}");
Console.Write($"5. feladat: ");
int oops = 0;
while (oops < jatek.Count && jatek[oops].tippek[0] != 1) { oops++; }
Console.WriteLine(oops < jatek.Count ? "Az első fordulóban volt egyes tipp" : "Az első fordulóban nem volt egyes tipp");
int valtozo = 0;
for (int i = 0; i < jatek.Count; i++)
{
    for (int k = 0; k < jatek[i].tippek.Count; k++)
    {
        if (jatek[i].tippek[k] > valtozo)
        {
            valtozo = jatek[i].tippek[k];
        }
    }
}
Console.WriteLine($"6. feladat: A legnagyobb tipp a fordulók során: {valtozo}");
Console.WriteLine($"7. feladat: Kérem a forduló sorszámát! [1-{Pontszam.Count}]");
int beker = int.Parse(Console.ReadLine()) - 1;
if (beker < 0 || beker > Pontszam.Count)
{
    beker = 0;
}
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < Pontszam.Count - 1; i++)
{
    int tipp = jatek[i].tippek[beker];
    if (dict.ContainsKey(tipp))
    {
        dict[tipp]++;
    }
    else
    {
        dict[tipp] = 1;
    }
}
var rendezett = dict.Where(x => x.Value == 1);
if (rendezett.Count() == 0)
{
    Console.WriteLine("8. Feladat: Nem volt nyertes tipp");
    Console.WriteLine("9. Feladat: Nem volt nyertes");
}
else
{
    StreamWriter r = new StreamWriter("nyertes.txt");
    r.WriteLine($"A forduló sorszáma: {beker}");
    int nyertes = rendezett.OrderBy(x => x.Key).First().Key;
    r.WriteLine($"Nyertes tipp: {nyertes}");
    Console.WriteLine($"8. feladat: A nyertes tipp a megadott fordulóban: {nyertes}");
    int i = 0;
    while (jatek[i].tippek[beker] != nyertes)
    {
        i++;
    }
    Console.WriteLine($"9. feladat: A megadott forduló nyertese: {jatek[i].nev}");
    r.WriteLine($"Nyertes Játékos: {jatek[i].nev}");
    r.Close();
}
class jatekosok
{
    public string nev;
    public List<int> tippek;
    public jatekosok(string nev, List<int> lista)
    {
        this.nev = nev;
        this.tippek = lista;
    }
}
*/

/*
//Advent of Code 2023 (Day 1)
StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\aocday1.txt");
int max = 0;
int osszead = 0;
while (!f.EndOfStream)
{
    string line = f.ReadLine();
    string szamok = "";
    int i = 0;
    while(i < line.Length && szamok.Length == 0)
    {
        if (char.IsNumber(line[i]))
        {
            szamok += line[i];
        }
        i++;
    }
    int j = line.Length - 1;
    while (j >= 0 && szamok.Length == 1)
    {
        if (char.IsNumber(line[j]))
        {
            szamok += line[j];
        }
        j--;
    }
    osszead = int.Parse(szamok);
    max += osszead;
    Console.WriteLine($"Sorok: {line}-{szamok}.");
}
Console.WriteLine($"Összeadva: {max}");
f.Close();
*/

/*
//Advent of Code 2023 (Day 2)
StreamReader f = new StreamReader("forras_2nap.txt");
List<string> fileData = new List<string>();
while (!f.EndOfStream)
{
    fileData.Add(f.ReadLine());
}
f.Close();

//sum id
int ids = 0;
//max szám mindhárom színre
Dictionary<string, int> dic = new Dictionary<string, int>() {{ "red", 12 }, { "green", 13 }, { "blue", 14 }};
// EZAZ
bool EZAZ;
for (int i = 0; i < fileData.Count; i++)
{
    //egész jelenlegi sor splittelve
    List<string> current = fileData[i].Split(new char[] {',', ';', ':'}).ToList();
    //eleinte true, jónak kezeljük a sort
    EZAZ = true;
    //fut a sor összes kis elemén
    for (int o = 1; o < current.Count; o++)
    {
        //dic[current[o].Split(' ')[0]]  ->  dictionaryben az adott színnek a max elfogadott értéke
        //int.Parse(current[o].Split(' ')[1])  ->  az adott húzásban az adott színből mennyi van

        string currentColor = current[o].Trim().Split(' ')[1];
        int currentAmount = int.Parse(current[o].Trim().Split(' ')[0]);
        if (currentAmount > dic[currentColor])
        {
            //ilyenkor a húzás sor bukta
            EZAZ = false;
        }
    }
    //ha TRUE maradt az értéke akkor nincs rossz étrék
    if (EZAZ)
    {
        //GAME SORSZÁMA
        ids += int.Parse(current[0].Split(' ')[1]);
    }
}
Console.WriteLine($"VÉGSŐ EREDMÉNY: {ids}");


// MÁSODIK RÉSZ

int sum = 0;
Dictionary<string, int> max = new Dictionary<string, int>();
List<int> powers = new List<int>();
for (int i = 0; i < fileData.Count; i++)
{
    max = new Dictionary<string, int>{ { "red", 0 }, { "green", 0 }, { "blue", 0 } };
    //egész jelenlegi sor splittelve
    List<string> current = fileData[i].Split(new char[] { ',', ';', ':' }).ToList();
    for (int o = 1; o < current.Count; o++)
    {
        string currentColor = current[o].Trim().Split(' ')[1];
        int currentAmount = int.Parse(current[o].Trim().Split(' ')[0]);
        //ha a jelenlegi szín túlmegy a recordált legnagybbon akkor arra állítja át
        if (currentAmount > max[currentColor])
        {
            max[currentColor] = currentAmount;
        }
    }
    //fela dat
    powers.Add(max["red"] * max["green"] * max["blue"]);
}

Console.WriteLine($"VÉGSŐ EREDMÉNY: {powers.Sum()}");
*/

/*
//Vírusok
Random r = new Random();
int random1 = r.Next(4, 20);
int[,] halo = new int[random1, random1];

int osszvirus = 0;
for (int i = 0; i < random1; i++)
{
    for (int j = 0; j < random1; j++)
    {
        if (r.Next(1, 11) < 3)
        {
            halo[i, j] = 1;
            osszvirus++;
        }
        else
        {
            halo[i, j] = 0;
        }
    }
}
for (int i = 0; i < random1; i++)
{
    for (int j = 0; j < random1; j++)
    {
        Console.Write(halo[i, j] + "\t");


    }
    Console.WriteLine();
}

while (random1 * random1 * 0.8 > osszvirus)
{
    for (int i = 0; i < random1; i++)
    {
        for (int j = 0; j < random1; j++)
        {
            if(szomszed(i, j) >= 2)
            {
                halo[i, j] = 1;
                osszvirus++;
            }
            else
            {
                halo[i, j] = 0;
            }
        }
    }
    Console.WriteLine();
    for (int i = 0; i < random1; i++)
    {
        for (int j = 0; j < random1; j++)
        {
            Console.Write(halo[i, j] + "\t");


        }
        Console.WriteLine();
    }
}

int szomszed(int sor, int oszlop)
{
    if (sor < 0 || sor >= random1 || oszlop < 0 || oszlop >= random1)
    {
        return 0;
    }
    int[] szomszed = new int[random1 * random1];
 
    for (int i = sor - 1; i <= sor + 1; i++)
    {
        for (int j = oszlop - 1; j <= oszlop + 1; j++)
        {
            if (i >= 0 && i < random1 && j >= 0 && j < random1)
            {
                szomszed[i * random1 + j] = halo[i, j];
            }
        }
    }
 
    int db = 0;
    for (int i = 0; i < szomszed.Length; i++)
    {
        if (szomszed[i] == 1)
        {
            db++;
        }
    }
 
    return db;
}
*/

/*
//Meteorológiai jelentés
StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\Meteo\Meteo\tavirathu13.txt");
List<Met> adatok = new List<Met>();
string sor = "";
while (!f.EndOfStream)
{
    sor = f.ReadLine();
    adatok.Add(new Met(sor.Split(" ")[0], sor.Split(" ")[1], sor.Split(" ")[2], int.Parse(sor.Split(" ")[3])));
}

Console.WriteLine("2. feladat");
Console.Write($"Adja meg a település kódját! Település: ");
string varosKod =  Console.ReadLine();
int utolsoMeres = 0;
for (int i = 0; i < adatok.Count; i++)
{
    if (adatok[i].telepules == varosKod && utolsoMeres < int.Parse(adatok[i].ido))
    {
        utolsoMeres = int.Parse(adatok[i].ido);
    }
}
Console.WriteLine($"Az utolsó mérési adat a megadott településről {utolsoMeres.ToString().Insert(2, ":")}-kor érkezett.");

Console.WriteLine("3. feladat");
int minHo = 100;
int maxHo = 0;
string minTelepules = "";
string maxTelepules = "";
int minIdo = 0;
int maxIdo = 0;
for (int j = 0; j < adatok.Count; j++)
{
    if (adatok[j].ho < minHo)
    {
        minHo = adatok[j].ho;
        minTelepules = adatok[j].telepules;
        minIdo = int.Parse(adatok[j].ido);
    }
    if (adatok[j].ho > maxHo)
    {
        maxHo = adatok[j].ho;
        maxTelepules = adatok[j].telepules;
        maxIdo = int.Parse(adatok[j].ido);
    }
}
Console.WriteLine($"A legalacsonyabb hőmérséklet: {minTelepules} {minIdo.ToString().Insert(2, ":")} {minHo} fok.");
Console.WriteLine($"A legmagasabb hőmérséklet: {maxTelepules} {maxIdo.ToString().Insert(2, ":")} {maxHo} fok.");

Console.WriteLine("4. feladat");
int szelCsend = 0;
for (int k = 0; k < adatok.Count; k++)
{
    if (adatok[k].szel == "00000")
    {
        Console.WriteLine($"{adatok[k].telepules} {adatok[k].ido.Insert(2, ":")}");
        szelCsend++;
    }
}
if (szelCsend == 0)
{
    Console.WriteLine("Nem volt szélcsend a mérések idején.");
}

//Innen gatya
Console.WriteLine("5. feladat");

List<Met> kozepHo = new List<Met>();
for (int l = 0; l < adatok.Count; l++)
{
    if (adatok[l].ido.StartsWith("01") || adatok[l].ido.StartsWith("07") || adatok[l].ido.StartsWith("13") || adatok[l].ido.StartsWith("19"))
    {
        kozepHo.Add(new Met(adatok[l].telepules, adatok[l].ido, adatok[l].szel, adatok[l].ho));
    }
}
string elozoTelepules = "BP";
int atlagHo = 0;
int muveletSzamlalo = 0;
for (int m = 0; m < adatok.Count; m++)
{
    if (elozoTelepules == kozepHo[m].telepules)
    {
        atlagHo += kozepHo[m].ho;
        muveletSzamlalo++;
    }
}
int kozepHomerseklet = atlagHo/muveletSzamlalo;
Console.WriteLine($"Középhőmérséklet: {kozepHomerseklet}");


Console.WriteLine("6. feladat");
//StreamWriter w = new StreamWriter(@"C:\Users\kemenes.marton\Downloads\Meteo\Meteo\");

class Met
{
    public string telepules;
    public string ido;
    public string szel;
    public int ho;

    public Met(string telepules, string ido, string szel, int ho)
    {
        this.telepules = telepules;
        this.ido = ido;
        this.szel = szel;
        this.ho = ho;
    }
}
*/

/*
//Hiányzások
StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\Hiányzások\Hiányzások\naplo.txt");
List<string> naplo = new List<string>();
List<Tanulo> tanulok = new List<Tanulo>();
string sor = "";
int bejegyzesekSzama = 0;
string[] tordelt;
while (!f.EndOfStream)
{
    sor = f.ReadLine();
    naplo.Add(sor);
    if (!sor.StartsWith("#"))
    {
        tordelt = sor.Split(" ");
        tanulok.Add(new Tanulo(tordelt[0] + tordelt[1], tordelt[2]));
        bejegyzesekSzama++;
    }
}
Console.WriteLine("2. feladat");
Console.WriteLine($"A naplóban {bejegyzesekSzama} bejegyzés van.");

Console.WriteLine("3. feladat");
int igazoltHiany = 0;
int igazolatlanHiany = 0;
for (int i = 0; i < tanulok.Count; i++)
{
    if (tanulok[i].hianyzas.Contains("X"))
    {
        igazoltHiany++;
    }else if (tanulok[i].hianyzas.Contains("I"))
    {
        igazolatlanHiany++;
    }
}
Console.WriteLine($"Az igazolt hiányzások száma {igazoltHiany}, az igazolatlanoké {igazolatlanHiany} óra.");

Console.WriteLine("5. feladat");
string hetnapja(int honap, int nap)
{
    string[] napnev = { "vasarnap", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat" };
    int[] napszam = {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335 };
    int napsorszam = (napszam[honap - 1] + nap);
    return napnev[napsorszam];
}
Console.Write("A hónap sorszáma=");
int honap = int.Parse(Console.ReadLine());
Console.Write("A nap sorszáma=");
int nap = int.Parse(Console.ReadLine());
Console.WriteLine($"Azon a napon {hetnapja(honap, nap)} volt.");

class Tanulo
{
    public string nev;
    public string hianyzas;

    public Tanulo(string nev, string hianyzas)
    {
        this.nev = nev;
        this.hianyzas = hianyzas;
    }
}
*/

/*
//Hiányzások (sexyBence)
StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\Hiányzások\Hiányzások\naplo.txt");
List<Hianyzas> tanulok = new List<Hianyzas>();
int honap = 0;
int nap = 0;
while (!f.EndOfStream)
{
    string sor = f.ReadLine();
    string[] adatok = sor.Split(" ");
    if (adatok[0] == "#")
    {
        honap = int.Parse(adatok[1]);
        nap = int.Parse(adatok[2]);
    }
    else
    {
        string nev = adatok[0] + " " + adatok[1];
        string ora = adatok[2];
        tanulok.Add(new Hianyzas(nev, honap, nap, ora));
    }
}
f.Close();
Console.WriteLine("2. feladat");
Console.WriteLine($"A naplóban {tanulok.Count} bejegyzés van.");

int igazolt = 0;
int igazolatlan = 0;
for (int i = 0; i < tanulok.Count; i++)
{
    for (int j = 0; j < tanulok[i].ora.Length; j++)
    {
        if (tanulok[i].ora[j] == 'X')
        {
            igazolt++;
        }else if (tanulok[i].ora[j] == 'I')
        {
            igazolatlan++;
        }
    }
}
Console.WriteLine("3. feladat");
Console.WriteLine($"Az igazolt hiányzások száma {igazolt}, az igazolatlanoké {igazolatlan} óra.");

string hetnapja(int honap, int nap)
{
    string[] napnev = { "vasárnap", "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat" };
    int[] napszam = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335};
    int napsorszam = (napszam[honap - 1] + nap)%7;
    return napnev[napsorszam];
}
Console.WriteLine("5. feladat");
Console.Write("A hónap sorszáma=");
int honapSorszam = int.Parse(Console.ReadLine());
Console.Write("A nap sorszáma=");
int napSorszam = int.Parse(Console.ReadLine());
Console.WriteLine($"Azon a napon {hetnapja(honapSorszam, napSorszam)} volt.");

Console.WriteLine("6. feladat");
Console.Write("A nap neve=");
string napNeve = Console.ReadLine();
Console.Write("Az óra sorszáma=");
int oraSorszam = int.Parse(Console.ReadLine());

int hianyzasokSzama = 0;
for (int k = 0; k < tanulok.Count; k++)
{
    if (hetnapja(tanulok[k].honap, tanulok[k].nap) == napNeve)
    {
        if (tanulok[k].ora[oraSorszam - 1] == 'X' || tanulok[k].ora[oraSorszam - 1] == 'I')
        {
            hianyzasokSzama++;
        }
    }
}
Console.WriteLine($"Ekkor összesen {hianyzasokSzama} óra hiányzás történt.");

public class Hianyzas
{
    public string nev;
    public int honap;
    public int nap;
    public string ora;

    public Hianyzas(string nev, int honap, int nap, string ora)
    {
        this.nev = nev;
        this.honap = honap;
        this.nap = nap;
        this.ora = ora;
    }
}
*/

/*
Windows Presentation Foundation (WPF)
asztali alkok grafikus felületének (UI) .NETtel történő alkalmazásprogramozási terület
deklaratyv felhasználói felület (XAML jelölőnyelvvel)
vektorgrafikus elemek (esztétikus átméretezés, kevesebb tárterület)
animációk deklaratív definiálása
grafikus gyorsítás (DirectX)
adatkötés (automatikus szinkronbn felhasználói felület és üzleti logika)
 
 
WINDOW osztály
fő ablak- alapértelmezett keret, címsor, minimalizáló és maximalizáló és bezáró gomb
a <Window> gyökérobjektum, melynk cask EGY gyermekeleme lehet, ezért hozta létre a VS számunkra a <Grid> objektumot benne, mert ez egy panel,bármennyi további panelt és vezérlőt tartalmazhat
 
ALAPVETŐ ÁLLOMÁNYAI
 
az app.xaml fileban az alk erőforrásait és indítási beállításait lehet definiálni. ez a file az Application gyökérelemmel kezdődik
 
a StartupUri tulaj. az alkalmazás elindulásakor először megjelenő ablakra mutat
adatokat adhatunk meg erőforrásként, (Resources), melyeket lokálisan az ablakhoz rebdelünk, vagy globálisan, az egész alkalmazásban használhatunk
 
App.xaml.cs - háttérkód
namespace elso_wpf
{
	public partial class App : APplication{
}
}
 
TULAJDONSÁGOK
 
x:Name nem tulajdonság, jellemző, ami egy azonosítót(futás idejű nevet) rendel az objektumpéldányhoz
C# kódból is lehet beállítani pl.: Gomb.Content = "Valami felirat";

VEZÉRLŐELEMEK
Alapvetően a Control osztály leszármazottjai
TextBlock szövegek megjelenítésére, nem vezérlő, nem a Control osztály leszármazottja, de ugyan úgy kell kezelni
Label vezérlő is ezt csinálja, de képet is tudunk rajta jeleníteni, egy soros szöveget lehet vele megjeleníteni, illetve képeket, de szövegre TextBox, kevésbé erőforrásigényes

TextBlock
<Grid>
    <TextBlock>
        Ez egy TextBlock.
    </TextBlock>
</Grid>
Ha hosszabb a szöveg, akkor nem tördeli automatikusan, hanem a szöveg kifolyik a képből
pl.
<TextBlock Margin="10">
    Ez egy többsoros szöveg, <LineBreak />
    amit sortöréssel jelenítünk meg.
</TextBlock>

<TextBlock Margin="10" TextTrimming="CharacterEllipsis vagy WordEllipsis">
    Ez egy többsoros szöveg, amit valószínüleg nem
    fogunk látni teljes mértékben, de jelzi.
</TextBlock>

<Grid>
    <TextBlock Margin="10" TextWrapping="Wrap">
        Ez egy hosszú szöveg, ami automatikusan darálódik a
        rendelkezésre álló hely függvényében.
    </TextBlock>
</Grid>
    - A <LineBreak/>-nél jobb megoldás

Szövegformázás
<Bold></Bold>;<Italic></Italic>;<Underline></Underline>;<Span></Span>
Hyperlink:
<TextBlock Margin="10" TextWrapping="Wrap">
    Ebben a szövegben egy <Hyperlink RequestNavigate = "Hyperlink_RequestNavigate" NavigateUri = "https://www.google.com">link</Hyperlink> található.
</TextBlock>
    - Ahhoz, hogy a külső URL-eket érjünk el a WPF alkalmazásból, a háttérkódban kezelnünk kell a RequestNavigate eseményt.
MainWindow.xaml.cs:
private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
{
    System.Diagnostics.Process.Start(e.Uri.AbsoluteUri)
}


Grid
a legkomplexebb paneltípus, amit használhatunk - ez is egy vezérlő, amely konténerként működik a többi vezérlő számára, és ezek elrendezését is szabályozhatjuk vele
oszlopokat, sorokat tartalmaz, melyeknek megadhatjuk szélességét/magasságát pixelben, egymáshoz viszonyított arányban (*), vagy auto módban - amikor a tartalomhoz illeszkedik a méret
UniformGrid - minden sor és oszlop azonos méretű
ha több vezérlőt teszünk az ablakba, egymás fölé helyezi őket (rétegek), ezért fel kell osztanunk a teret a ColumnDefinition és RowDefinition tagekkel
<Grid>
    <Grid.ColoumnDefinitions>
</Grid>

GridSplitter
ha engedni szeretnénk, hogy a felhasználó átméretezze, újraossza a teret a Grid sorai vagy oszlopai között
hozzáadjuk egy új oszlopként (vagy sorként), adunk neki minimális méretet (Width/Height), a felhasználó el fogja tudni húzni a megfelelő irányba

GridSplitter - függőleges
<Grid>
    <GridSplitter Grid.Column="1" Width="5" HorizontalAlignment="Center" VerticalAlingment="Stretch" />
</Grid>

GridSplitter - vízszintes
<Grid>
    <GridSplitter Grid.Row="1" Height="5" HorizontalAlingment="Stretch" VerticalAlingment="Center">
</Grid>

Button - nyomógomb
<Button>Hello, World!</Button>
Ez a gomb nem csinál semmit, de fel tudunk iratkozni a Click eseményre.
<Button Click="HelloWorldButton_Click">Hello, World!</Button>
A C# forráskódban egy megfelelő metódusra lesz szükségünk a 'Click' kezeléséhez:
private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Hello, World!");
}

CheckBox vezérlő
logikai értéket kérhetünk be vele

<CheckBox x:Name="cbxOne" isChecked="False">Check Box One</CheckBox>
<CheckBox x:Name="cbxTwo" isChecked="True">Check Box Two</CheckBox>
<CheckBox x:Name="cbxThree" isChecked="False" isEnabled="False">Check Box Three</CheckBox>
<CheckBox x:Name="cbxFour" isChecked="True" isEnabled="False">Check Box Four</CheckBox>
<Button x:Name="btnShowMe" width="80" Click="btnShowMe_Click">Show Me</Button>

Ha a késöbbiekben akarunk hivatkozni rájuk a kódból, névvel kell ellásuk őket

private void btnShowMe_Click(object sender, RoutedEventArgs e)
{
    if (cbxOne.IsChecked == true)
        MessageBox.Show("Első");
    if ((bool) cbxTwo.IsChecked)
        MessageBox.Show("Második");
}
Beállíthatjuk, hogy legyen 3 különböző állapota, igaz, hamis és meg nem határozott (null):
<CheckBox IsThreeState="True" ... /> (ezért kell az IsChecked értékét bool-ra konvertálni)

RadioButton
több lehetséges opció közül választhatunk ki egyet egy időben
<StackPanel Margin="40">
    <Label FontWeight="Bold">Okos vagyok?</Label>
    <RadioButton GroupName="okos">Igen</RadioButton>
    <RadioButton GroupName="okos">Nem</RadioButton>
    <RadioButton GroupName="okos" IsChecked="True">Talán</RadioButton>

    <Label FontWeight="Bold">Szép vagy?</Label>
    <RadioButton GroupName="szép">Igen</RadioButton>
    <RadioButton GroupName="szép">Nem</RadioButton>
    <RadioButton GroupName="szép" IsChecked="True">Talán</RadioButton>
</StackPanel>

PassWordBox vezérlő
Ugyanúgy működik, mint a TextBox, de meg tudjuk védeni az információt a kíváncsi tekintetektől
<StackPanel Margin="10">
    <Label>User name:</Label>
    <TextBox />
    <Label>Password:</Label>
    <PassWordBox />
</StackPanel>

- <PassWordBox PasswordChar="X" />
- <PassWordBox MaxLength="8" />

Image vezérlő
<Image Source="https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Shiba-inu_Magyarorsz%C3%A1g.jpg/640px-Shiba-inu_Magyarorsz%C3%A1g.jpg"/>
-ahelyett, hogy külső forrásból töltenénk le a képet, érdemes egybecsomagolni az alkalmazással:
    - Solution Explorerben projekt nevére jobb klikk -> Add -> New Folder: Kepek
    - Kepek jobb click -> Add -> Existing Item -> Tallózás -> képfájl -> Add
    - képfájl: Properties -> Build Action: Resource

    <Image Source="Kepek/kutya-osszel-1.jpg"/>
- másik fontos tulajdonság a Strech
    Lehetséges értékei:
        - Uniform (alapértelmezett): A kép automatikusan méreteződik, hogy beférjen a rendelkezésre álló helyre. Méretarány viszont kötött, a kép nem torzul
        - UniformToFill: méretarány itt is kötött, de lehet hogy a kép egyes részei kilógnak
        - Fill: a méretarány nem kötött, a kép torzulhat
        - None: Ha a kép kisebb, mint a rendelkezésre álló terület, semmi sem történik. Ha a kép nagyobb, akkor a kilógó terület le lesz vágva

ListBox
<ListBox Margin="10,10,0,13" Name="listBox1" HorizontalAlignment="Left" VerticalAlignment="Top" Width="194" Height="200">
    <ListBoxItem Content="Coffee"></ListBoxItem>
    <ListBoxItem Content="Tea"></ListBoxItem>
    <ListBoxItem Content="Orange Juice"></ListBoxItem>
    <ListBoxItem Content="Milk"></ListBoxItem>
    <ListBoxItem Content="Iced Tea"></ListBoxItem>
    <ListBoxItem Content="Mango Shake"></ListBoxItem>
</ListBox>
    elemek hozzáadása:
    private void button1_Click(object sender, RoutedEventArgs e)
    {
        listBox1.Items.Add(textBox1.Text);
    }

    elemek törlése
    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem))
    }
    elemek rendezése
    private void button1_Click(object sender, RoutedEventArgs e)
    {
        listBox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending))
    }

ComboBox vezérlő
egy értéket kiválaszthatunk a legördülő menüből
<ComboBox Margin="10,10,0,13" Name="ComboBox1" HorizontalAlignment="Left" VerticalAlignment="Top" Width="194" Height="30">
    <ComboBoxItem Content="Coffee"></ComboBoxItem>
    <ComboBoxItem Content="Tea"></ComboBoxItem>
    <ComboBoxItem Content="Orange Juice"></ComboBoxItem>
    <ComboBoxItem Content="Milk"></ComboBoxItem>
    <ComboBoxItem Content="Iced Tea"></ComboBoxItem>
</ComboBox>
elem hozzáadása a ComboBoxhoz
private void AddButton_Click(object sender, RoutedEventArgs e)
{
    ComboBox1.Items.Add(TextBox1.Text);
}
elem törlése
ComboBox1.Items.RemoveAt(ComboBox1.Items.IndexOf(ComboBox1.SelectedItem));

Vezérlők, melyek konténerként működnek más vezérlők számára:
Canvas, WrapPanel, StackPanel, DockPanel, Grid, UniformGrid

Canvas
Elsősorban rajzok készítéséhez használjuk, de elhelyezhetünk rajta más vezérlőket is, a pozicionálásról mi gondoskodunk (alapból a bal felső sarok)
<Canvas>
    <Button Canvas.Left="10">Top Left</Button>
    <Button Canvas.Right="10">Top Right</Button>
    <Button Canvas.Left="10" Camvas.Bottom="10">Bottom Left</Button>
    <Button Canvas.Right="10" Canvas.Bottom="10">Bottom Right</Button>
</Canvas>

Canvas - Z Index tulajdonság
Ha a vezérlők átfedésbe kerülnek, meghatározhatjuk a rétegzési sorrendet. Alapból a később meghatározott kerül felülre.
<Canvas>
    <Ellipse Fill="LightGray" Canvas.Left="25" Canvas.Top="25" Width="200" Height="200" />
    <Rectangle Panel.ZIndex="2" Fill="LightBlue" Canvas.Left="25" Canvas.Top="25" Width="50" Height="50">
    <Rectangle Panel.ZIndex="1" Fill="LightCoral" Canvas.Left="25" Canvas.Top="50" Width="50" Height="50">
    <Rectangle Panel.ZIndex="3" Fill="LightGreen" Canvas.Left="25" Canvas.Top="75" Width="50" Height="50">
</Canvas>
A ZIndex alapból 0, minél nagyobb értéket adunk neki, annál felsőbb rétegbe kerül az objektum
Alakzatok
Ellipse, Line, Path, Polygon, Polyline, Rectangle
Közös tulajdonságok
Stroke (szegély), StrokeThickness, Fill
*/
