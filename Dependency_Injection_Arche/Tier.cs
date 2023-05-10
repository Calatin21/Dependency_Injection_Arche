namespace Dependency_Injection_Arche {
    internal class Tier : Lebensform, IVerantwortlicher {
        public bool BerechtigungPruefen(IBerechtigung berechtigter) {
            bool ergebnis = false;
            if (berechtigter is Tier) {
                ergebnis = true;
            }
            else if (berechtigter is Alien) {
                ergebnis = true;
            }
            else if (berechtigter is Untier) {
                ergebnis = false;
            }
            else if (berechtigter is Mensch) {
                if (((Mensch)berechtigter).Name == "Hanni" || ((Mensch)berechtigter).Name == "Nanni" || ((Mensch)berechtigter).Name == "Fliwatüt" || ((Mensch)berechtigter).Name == "Donald" || ((Mensch)berechtigter).Name == "Der Imperator") {
                    ergebnis = false;
                }
                else if (berechtigter is Mensch) {
                    ergebnis = true;
                }
            }
            return ergebnis;
        }
        
    }
}
