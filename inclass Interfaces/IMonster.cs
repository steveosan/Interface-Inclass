namespace inclass_Interfaces
{
    public interface IMonster : ICombatant
    {


        void Roar() 
        {
            System.Console.WriteLine("I am a monster");
        }
    }
}