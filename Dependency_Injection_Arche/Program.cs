namespace Dependency_Injection_Arche {
    internal class Program {
        static void Main(string[] args) {
            Arche arche = new Arche( new Tier() { Name = "Das Unsichtbare rosa Einhorn" });
            Untier ut = new() { Name = "Bestie jo"};
            Tier tier = new() { Name = "leika" };
            Mensch orange = new() { Name = "Donald" };
            Mensch sith = new() { Name = "Der Imperator" };
            Mensch zwilling = new() { Name = "Hanni" };
            arche.AddMitreisenden(ut);
            arche.AddMitreisenden(tier);
            arche.AddMitreisenden(orange);
            arche.AddMitreisenden(sith);
            arche.AddMitreisenden(zwilling);
            arche.ZeigeAlleMitreisenden();

        }
    }
}