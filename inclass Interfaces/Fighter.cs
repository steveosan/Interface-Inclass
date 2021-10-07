namespace inclass_Interfaces
{
    public class Fighter : ICombatant
    {
        public string Name {get;set;}

        public Armor Armor {get;set;}
        public Weapon Weapon {get;set;}
        public Weapon weapon { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Fighter()
        {
            Name = "fighter";
            Armor = new Armor();
            Weapon = new Weapon();
        }
        public void Attack(Enemy enemy) {
            if (this.Weapon.Power >  enemy.Armor.Defence ) {
                System.Console.WriteLine($"{this.Name} attacks {enemy.Name} with his {this.Weapon.Name}");
            }
            else {
                System.Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Armor.Name}");
            }
        }

        public void Defend() {

        }

        public void Defend(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Attack(inclass_Interfaces.ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(inclass_Interfaces.ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public interface ICombatant {
            void Attack (Enemy enemy);
            void Defend (Enemy enemy);
        }

    }
}