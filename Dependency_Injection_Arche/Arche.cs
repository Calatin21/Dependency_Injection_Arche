namespace Dependency_Injection_Arche {
    internal class Arche {
        public IVerantwortlicher Verantwortlicher { get; set; }
        public List<Lebensform> Reisende { get; set; } = new List<Lebensform>();
        public Arche(IVerantwortlicher chef) {
            Verantwortlicher = chef;
        }
        public void AddMitreisenden(Lebensform lf) {
            IBerechtigung ib = (IBerechtigung)lf;
            if (Verantwortlicher.BerechtigungPruefen(ib)) {
                ib.eintreten(this);
            }else {
                Console.WriteLine("Stand auf der Blacklist");
            }
        }
        public void ZeigeAlleMitreisenden() {
            Console.WriteLine($"Verantwortlich ist {((Lebensform)Verantwortlicher).Name}\nListe aller reisenden:");
            foreach(IBerechtigung item in Reisende) {
                Console.WriteLine(item.ZeigeInfo());
            }
        }
    }
}
