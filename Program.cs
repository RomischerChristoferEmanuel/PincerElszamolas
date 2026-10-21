using PincerElszamolas;

string[] c = File.ReadAllLines("pincerek.txt");
List<Pincer> pincerlista= new List<Pincer>();
//Console.WriteLine(c);

foreach (string l in c)
{
    Pincer mml= new Pincer();
    string[] vag= l.Split(',');
    mml.PincerNev= vag[0];
    mml.Felszolgaltasztalok=int.Parse(vag[1]);
    mml.NapiBevetelFt = int.Parse(vag[2]);
    mml.ReklamaciokSzama = int.Parse(vag[3]);

    pincerlista.Add(mml);
}