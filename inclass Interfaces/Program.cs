﻿using System;

namespace inclass_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Fighter (instantiate object)
            //Equip Armor (assign value)
            //Equip Weapon (assign value) 
            Fighter fighter = new Fighter();
            fighter.Armor.Defence = 10;
            fighter.Weapon.Power = 10;

            //Attack Enemy (execute method)
            Enemy enemy = new Enemy();
            enemy.Armor.Defence = 10;
            enemy.Weapon.Power = 8;


            fighter.Attack(enemy);

            IMonster monster = null;
            monster.Roar();


        }
    }
}
