using PincerElszamolas;

string[] c = File.ReadAllLines("pincerek.txt");
List<Pincer> pincerlista= new List<Pincer>();
//Console.WriteLine(c);
double x = 0;
double y =0;
double z = 0;
foreach (string l in c)
{
    Pincer mml= new Pincer();
    string[] vag= l.Split(',');
    mml.PincerNev= vag[0];
    mml.Felszolgaltasztalok=int.Parse(vag[1]);
    mml.NapiBevetelFt = int.Parse(vag[2]);
    mml.ReklamaciokSzama = int.Parse(vag[3]);

    pincerlista.Add(mml);
    x+=mml.NapiBevetelFt;
    if(mml.Felszolgaltasztalok>=12 && mml.ReklamaciokSzama == 0)
    {
        x += 10000;
    }
    else if (mml.ReklamaciokSzama >= 2)
    {
        x -= 8000;

    }

    Console.WriteLine("Pincérek napi elszámolása:");
    Console.WriteLine($"{mml.PincerNev}: {mml.Felszolgaltasztalok} asztal, {mml.NapiBevetelFt} Ft bevétel (Reklamáció: {mml.ReklamaciokSzama}) - Fizetés: {x+(x*0.05)} Ft");
}