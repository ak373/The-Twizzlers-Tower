using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    class Stats
    {
        public string Name;
        public int CurrentHitPoints;
        public int MaxHitPoints;
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
        public int HotActive;
        public int DotActive;
        public int BankedCrystals;
        public bool TheCreeperInTheDarkDefeated;
        public bool SalamancaGuardDefeated;
        public bool SalamancaCousinDefeated;
        public bool FredDefeated;
        public bool JesseDefeated;
        public bool DudeOnAPogoStickDefeated;

        public Stats(string aName, int aCurrentHitPoints, int aMaxHitPoints, Armor aEquippedArmor, Weapon aEquippedWeapon, Shield aEquippedShield, int aArmorClass, double aCritResist, int aDamageReduction, int aDamageDie, int aDamage, double aCritMultiplier, int aBlueCrystals, int aFightClubRank, string aLocation, string aFleeLocation, bool aJustFled, bool aJanesProtectionActive, string aLastDefeated, int aFlurry, int aToHitMod, int aHotActive, int aDotActive, int aBankedCrystals, bool aTheCreeperInTheDarkDefeated, bool aSalamancaGuardDefeated, bool aSalamancaCousinDefeated, bool aFredDefeated, bool aDudeOnAPogoStickDefeated, bool aJesseDefeated)
        {
            Name = aName;
            CurrentHitPoints = aCurrentHitPoints;
            MaxHitPoints = aMaxHitPoints;
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
            HotActive = aHotActive;
            DotActive = aDotActive;
            BankedCrystals = aBankedCrystals;
            TheCreeperInTheDarkDefeated = aTheCreeperInTheDarkDefeated;
            SalamancaGuardDefeated = aSalamancaGuardDefeated;
            SalamancaCousinDefeated = aSalamancaCousinDefeated;
            FredDefeated = aFredDefeated;
            DudeOnAPogoStickDefeated = aDudeOnAPogoStickDefeated;
            JesseDefeated = aJesseDefeated;
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
        public int CurrentHitPoints;
        public int MaxHitPoints;
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

        public BadGuyStats(string aName, int aCurrentHitPoints, int aMaxHitPoints, int aArmorClass, double aCritResist, int aDamageDie, int aDamage, double aCritMultiplier, int aBlueCrystals, int aPotionCount, Potion aPotionType, Weapon aWeapon, Armor aArmor, string aBattleIntro)
        {
            Name = aName;
            CurrentHitPoints = aCurrentHitPoints;
            MaxHitPoints = aMaxHitPoints;
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
