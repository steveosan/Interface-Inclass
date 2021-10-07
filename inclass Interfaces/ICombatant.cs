namespace inclass_Interfaces
{
    public interface ICombatant
    {
        public string Name {get;set;}
        public Armor Armor {get;set;}

        public Weapon weapon {get;set;}

        void Attack(ICombatant enemy);

        void Defend(ICombatant enemy);
    }
}