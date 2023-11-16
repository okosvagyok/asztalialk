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
*/

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

//Osztálypénz feladat
Random r = new Random();
List<Tanulo> tanulok = new List<Tanulo>();
int letszam = r.Next(5, 16);
for(int i = 0; i<letszam; i++)
{
    tanulok.Add(new Tanulo(i+1));
}

class Tanulo
{
    public int sorszam;
    public int kezdoegyenleg;
    public int egyenleg;
    Random rnd = new Random()
    List<Befizetes> tranzakciok;

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