using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    class Stats
    {
        public string Name;
        public int MaxHitPoints;
        public int CurrentHitPoints;
        public Armor EquippedArmor;
        public Weapon EquippedWeapon;
        public Shield EquippedShield;
        public int ArmorClass;
        public double CritResist;
        public int DamageReduction;
        public int DamageDie;
        public int Damage;
        public double CritMultiplier;
        public int BlueCrystals;
        public int FightClubRank;
        public string Location;
        public string FleeLocation;
        public bool JustFled;
        public bool JanesProtectionActive;
        public string LastDefeated;
        public int Flurry;
        public int ToHitMod;

        public Stats(string aName, int aMaxHitPoints, int aCurrentHitPoints, Armor aEquippedArmor, Weapon aEquippedWeapon, Shield aEquippedShield, int aArmorClass, double aCritResist, int aDamageReduction, int aDamageDie, int aDamage, double aCritMultiplier, int aBlueCrystals, int aFightClubRank, string aLocation, string aFleeLocation, bool aJustFled, bool aJanesProtectionActive, string aLastDefeated, int aFlurry, int aToHitMod)
        {
            Name = aName;
            MaxHitPoints = aMaxHitPoints;
            CurrentHitPoints = aCurrentHitPoints;
            EquippedArmor = aEquippedArmor;
            EquippedWeapon = aEquippedWeapon;
            EquippedShield = aEquippedShield;
            ArmorClass = aArmorClass;
            CritResist = aCritResist;
            DamageReduction = aDamageReduction;
            DamageDie = aDamageDie;
            Damage = aDamage;
            CritMultiplier = aCritMultiplier;
            BlueCrystals = aBlueCrystals;
            FightClubRank = aFightClubRank;
            Location = aLocation;
            FleeLocation = aFleeLocation;
            JustFled = aJustFled;
            JanesProtectionActive = aJanesProtectionActive;
            LastDefeated = aLastDefeated;
            Flurry = aFlurry;
            ToHitMod = aToHitMod;
        }

        public string[] GetStats()
        {
            string maxHP = MaxHitPoints.ToString();
            string currentHP = CurrentHitPoints.ToString();
            string combinedHP = currentHP + " / " + maxHP;
            string armorClass = ArmorClass.ToString();
            string damageReduction = DamageReduction.ToString();
            string critResist = CritResist.ToString();
            string damage = DamageDie + " + " + Damage.ToString();
            string critMultiplier = CritMultiplier.ToString();

            string[] statGrid =
            {
                "HP: " + combinedHP,
                "AC: " + armorClass,
                "Dmg Reduction: " + damageReduction,
                "Crit Resist: " + critResist + "x",
                "Damage: d" + damage,
                "Crit: " + critMultiplier + "x"
            };

            return statGrid;
        }
    }
    class BadGuyStats
    {
        public string Name;
        public int MaxHitPoints;
        public int CurrentHitPoints;
        public int ArmorClass;
        public double CritResist;
        public int DamageDie;
        public int Damage;
        public double CritMultiplier;
        public int BlueCrystals;
        public int PotionCount;
        public Potion PotionType;
        public Weapon Weapon;
        public Armor Armor;
        public string BattleIntro;

        public BadGuyStats(string aName, int aMaxHitPoints, int aCurrentHitPoints, int aArmorClass, double aCritResist, int aDamageDie, int aDamage, double aCritMultiplier, int aBlueCrystals, int aPotionCount, Potion aPotionType, Weapon aWeapon, Armor aArmor, string aBattleIntro)
        {
            Name = aName;
            MaxHitPoints = aMaxHitPoints;
            CurrentHitPoints = aCurrentHitPoints;
            ArmorClass = aArmorClass;
            CritResist = aCritResist;
            DamageDie = aDamageDie;
            Damage = aDamage;
            CritMultiplier = aCritMultiplier;
            BlueCrystals = aBlueCrystals;
            PotionCount = aPotionCount;
            PotionType = aPotionType;
            Weapon = aWeapon;
            Armor = aArmor;
            BattleIntro = aBattleIntro;
        }

        public BadGuyStats RewriteBadGuy(string aName, int aCurrentHitPoints, int aMaxHitPoints, int aArmorClass, double aCritResist, int aDamageDie, int aDamage, double aCritMultiplier, int aBlueCrystals, int aPotionCount, Potion aPotionType, Weapon aWeapon, Armor aArmor, string aBattleIntro)
        {
            BadGuyStats badGuy = new BadGuyStats(aName, aCurrentHitPoints, aMaxHitPoints, aArmorClass, aCritResist, aDamageDie, aDamage, aCritMultiplier, aBlueCrystals, aPotionCount, aPotionType, aWeapon, aArmor, aBattleIntro);

            return badGuy;
        }




    }
}
