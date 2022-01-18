﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Warrior : Character, ILevelUp, IEquip
    {
        //sets base attributes attributes[0] = strength, [1] = Dexterity, [2] = Intelligence
        Attributes attributes = new Attributes(5, 1, 1);

        public Warrior(string name, string race, CharacterClass characterClass)
        {
            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            Console.WriteLine("A warrior has been created");
        }

        //Should add specific item to existing item slot.
        public void Equip()
        {
            
        }
        //Increases the attributes of the warrior class
        public void LevelUp()
        {
            attributes.Strength += 5;
            attributes.Dexterity += 1;
            attributes.Intelligence += 1;
            Console.WriteLine($"Warrior {this.Name} just leveled up!");
        }

        public void PrintAttributes()
        {
            Console.WriteLine($"{Name} the {characterClass} has {attributes.Strength} strength, {attributes.Dexterity} dexterity and {attributes.Intelligence} intelligence!");
        }

    }
}
