using PincerElszamolas;

string[] c = File.ReadAllLines("pincerek.txt");
List<Pincer> pincerlista= new List<Pincer>();
//Console.WriteLine(c);
int x = 0;
double y =0;
double z = 0;
double ul = 0;
double alap = 0;
double atlag = 0;
int szamol = 0;
string ujj = "";
int reklnel = 0;
int rekk = 0;
Console.WriteLine("Pincérek napi elszámolása:");
foreach (string l in c)
{
    Pincer mml= new Pincer();
    string[] vag= l.Split(';');
    mml.PincerNev= vag[0];
    mml.FelszolgaltAsztalok=int.Parse(vag[1]);
    mml.NapiBevetelFt = int.Parse(vag[2]);
    mml.ReklamaciokSzama = int.Parse(vag[3]);

    pincerlista.Add(mml);
    //alap+=mml.NapiBevetelFt;


    alap = 15000 + mml.NapiBevetelFt * 0.05;


    if(mml.FelszolgaltAsztalok>=12 && mml.ReklamaciokSzama == 0)
    {
        alap += 10000;
    }
    else if (mml.ReklamaciokSzama >= 2)
    {
        alap -= 8000;

    }
    z+=alap;
    y = c.Count();

    if (szamol < alap)
    {
        szamol += (int)(alap);
        ujj = mml.PincerNev;
    }

    if (mml.ReklamaciokSzama < 2)
    {
        reklnel = mml.ReklamaciokSzama;
        rekk = reklnel;
    }
    
    ul += mml.FelszolgaltAsztalok;

    Console.WriteLine($"{mml.PincerNev}: {mml.FelszolgaltAsztalok} asztal, {x} Ft bevétel (Reklamáció: {mml.ReklamaciokSzama}) - Fizetés: {alap} Ft");
}
atlag = ul / y;

Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Étterem által kifizetett teljes összeg: {z} Ft");
Console.WriteLine($"Átlagos felszolgált asztalszám pincérenként: {atlag:f0} asztal");
Console.WriteLine($"Legmagasabb napi fizetés: {ujj} ({szamol} Ft)");
Console.WriteLine($"Reklamáció nélkül dolgozó pincérek száma: {rekk} fő");


