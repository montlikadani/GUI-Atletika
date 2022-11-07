namespace atletikaGUI {
    internal class Versenyzo {

        public readonly string VersenySzam, VersenyzoNev, Eredmeny, Csucs, Nemzet;
        public readonly char Neme, NemzetKod;
        public readonly int Helyezes;

        public Versenyzo(string versenySzam, string versenyzoNev, string eredmeny, string csucs, char neme, char nemzetKod, int helyezes, string nemzet) {
            VersenySzam = versenySzam;
            VersenyzoNev = versenyzoNev;
            Eredmeny = eredmeny;
            Csucs = csucs;
            Neme = neme;
            NemzetKod = nemzetKod;
            Helyezes = helyezes;
            Nemzet = nemzet;
        }
    }
}
