namespace inclass_Interfaces
{
    public class Boss: ICombatant
    {
        public string Name {get;set;}

        public Armor Armor {get;set;}
        public Weapon Weapon {get;set;}
        public Weapon weapon { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Boss()
        {
            Name = "Boss";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Attack(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}