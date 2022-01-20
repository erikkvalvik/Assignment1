using System;

namespace Assignment1
{
    public class RPGCharacters
    {
        static void Main(string[] args)
        {
            //Creating one of each class
            Warrior warrior = new Warrior("Brutus", "Orc", Character.CharacterClass.Warrior);
            Mage mage = new Mage("Leo", "Human", Character.CharacterClass.Mage);
            Rogue rogue = new Rogue("Rogue", "Human", Character.CharacterClass.Rogue);
            Ranger ranger = new Ranger("Ranger", "Elf", Character.CharacterClass.Ranger);

            //Creating some armor and weapons
            Armor clothChest = new Armor("Apprentice Robe", Armor.Material.Cloth, 0, 1, 0, Items.ItemSlot.Body, 1);
            Armor plateChest = new Armor("Monkeys Chestplate", Armor.Material.Plate, 1, 0, 0, Items.ItemSlot.Body, 1);
            Armor leatherChest = new Armor("Thieves Vest", Armor.Material.Leather, 0, 0, 1, Items.ItemSlot.Body, 1);
            Armor mailHelmet = new Armor("Mail Helmet", Armor.Material.Mail, 1, 0, 2, Items.ItemSlot.Head, 3);
            Weapons sword = new Weapons("Simple Sword", 1, Weapons.WeaponType.Sword, 5, 1);
            Weapons bow = new Weapons("Crude Bow", 1, Weapons.WeaponType.Bow, 4, .75);
            Weapons staff = new Weapons("Wizards Staff", 1, Weapons.WeaponType.Staff, 8, 0.3);

            //Equipping items
            rogue.EquipArmor(leatherChest);
            rogue.EquipWeapon(sword);
            rogue.LevelUp();
            rogue.LevelUp();
            warrior.EquipArmor(plateChest);

            //Displaying character statistics
            rogue.DisplayStats();

            //Writing to console for testing
            Console.WriteLine("weapon dps " + rogue.EquippedWeapon.GetDPS() + "weapon base damage " + rogue.EquippedWeapon.baseDamage);




        }

        public static void PrintClassDetails(Character charName)
        {
            Console.WriteLine($"name: {charName.Name} race: {charName.Race}  class: {charName.characterClass}");
        }

        public static void GenerateItems()
        {

        }
    }
}
