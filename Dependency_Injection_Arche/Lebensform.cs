namespace Dependency_Injection_Arche {
    abstract class Lebensform : IBerechtigung {
        public string Name { get; set; }
        public string ZeigeInfo() {
            return this.Name;
        }
        public void eintreten(Arche arche) {
            arche.Reisende.Add(this);
        }
    }
}
