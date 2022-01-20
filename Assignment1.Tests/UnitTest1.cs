using System;
using Xunit;

namespace Assignment1.Tests
{
    public class UnitTest1
    {
        

        [Fact]
        public void EquipWeapon_ShouldReturnEquippedWeapon()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Weapons testAxe = new Weapons()
            {
                Name = "Common axe",
                itemLevel = 1,
                slot = Items.ItemSlot.Weapon,
                weaponType = Weapons.WeaponType.Axe,
                baseDamage = 7,
                attacksPerSecond = 1.1
            };

            //Act
            testWarrior.EquipWeapon(testAxe);
            Weapons actual = testWarrior.EquippedWeapon;

            //Assert
            Assert.Equal(testAxe, actual);

        }
        [Fact]
        public void EquipWeapon_EquipHighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Weapons testAxe = new Weapons()
            {
                Name = "Common axe",
                itemLevel = 2,
                slot = Items.ItemSlot.Weapon,
                weaponType = Weapons.WeaponType.Axe,
                baseDamage = 7,
                attacksPerSecond = 1.1
            };

            //Act
            

            //Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testAxe));
        }
        [Fact]
        public void EquipArmor_EquipHighLevelArmor_ShouldThrowInvalidArmorException()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Armor plateArmor = new Armor()
            {
                Name = "Common plate body armor",
                itemLevel = 2,
                itemSlot = Items.ItemSlot.Body,
                armorStrength = 1,
                armorType = Armor.Material.Plate
            };

            //Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmor(plateArmor));
        }
        [Fact]
        public void EquipWeapon_EquipWrongWeaponType_ShouldThrowInvalidArmorException()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Weapons testBow = new Weapons()
            {
                Name = "Common Bow",
                itemLevel = 1,
                slot = Items.ItemSlot.Weapon,
                weaponType = Weapons.WeaponType.Bow,
                baseDamage = 12,
                attacksPerSecond = 0.8
            };

            //Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testBow));
        }
        [Fact]
        public void EquipArmor_EquipWrongArmorType_ShouldThrowInvalidArmorException()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Armor testArmor = new Armor()
            {
                Name = "Common cloth head armor",
                itemLevel = 1,
                itemSlot = Items.ItemSlot.Head,
                armorType = Armor.Material.Cloth,
                armorIntelligence = 5,
            };

            //Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmor(testArmor));
        }
        [Fact]
        public void EquipWeapon_EquipValidWeapon_ShouldReturnSuccessMessage()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Weapons testAxe = new Weapons()
            {
                Name = "Common axe",
                itemLevel = 1,
                slot = Items.ItemSlot.Weapon,
                weaponType = Weapons.WeaponType.Axe,
                baseDamage = 7,
                attacksPerSecond = 1.1
            };

            //Act
            string actual = testWarrior.EquipWeapon(testAxe);

            //Assert
            Assert.Equal("New weapon equipped!", actual);

        }
        [Fact]
        public void EquipArmor_EquipValidArmor_ShouldReturnSuccessMessage()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);
            Armor testArmor = new Armor()
            {
                Name = "Plate Armor",
                itemLevel = 1,
                armorType = Armor.Material.Plate,
                armorStrength = 1,
                armorDexterity = 0,
                armorIntelligence = 0,
                itemSlot = Items.ItemSlot.Body
            };

            //Act
            string actual = testWarrior.EquipArmor(testArmor);

            //Assert
            Assert.Equal("New armor equipped!", actual);
        }
        [Fact]
        public void CalculateCharacterDamage_CalculateDamageWithNoWeapon_ShouldReturnSum()
        {
            //Arrange
            Warrior testWarrior = new Warrior("Test Warrior", "Human", Character.CharacterClass.Warrior);

            //Act
            double actual = testWarrior.CalculateCharacterDamage();
            
            //Assert
            Assert.Equal(1.05, actual); // using 1*(1+(5/100)) sets Expected to be 1 for some reason.

        }
    }
}
