using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DnD_Battle.Creatures;

namespace DnD_Battle
{
    internal class DMG
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public DMG(DMG _DMG) {
            if (_DMG == null) _DMG = new DMG();
            foreach (PropertyInfo property in typeof(DMG).GetProperties()) {
                property.SetValue(this, property.GetValue(_DMG));
            }

            HealC = Heal?.Roll(true) ?? 0;
            PierceC = Pierce?.Roll(true) ?? 0;
            BluntC = Blunt?.Roll(true) ?? 0;
            SlashC = Slash?.Roll(true) ?? 0;
            AcidC = Acid?.Roll(true) ?? 0;
            ColdC = Cold?.Roll(true) ?? 0;
            FireC = Fire?.Roll(true) ?? 0;
            ForceC = Force?.Roll(true) ?? 0;
            LightningC = Lightning?.Roll(true) ?? 0;
            NecroticC = Necrotic?.Roll(true) ?? 0;
            PoisonC = Poison?.Roll(true) ?? 0;
            PsychicC = Psychic?.Roll(true) ?? 0;
            RadiantC = Radiant?.Roll(true) ?? 0;
            ThunderC = Thunder?.Roll(true) ?? 0;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.



        public DMG(Dice? heal = null, Dice? piercing = null, Dice? blunt = null, Dice? slashing = null, Dice? acid = null, Dice? cold = null, Dice? fire = null, Dice? force = null,
               Dice? lightning = null, Dice? necrotic = null, Dice? poison = null, Dice? psychic = null, Dice? radiant = null, Dice? thunder = null) {

            Heal = heal ?? new Dice();
            Pierce = piercing ?? new Dice();
            Blunt = blunt ?? new Dice();
            Slash = slashing ?? new Dice();
            Acid = acid ?? new Dice();
            Cold = cold ?? new Dice();
            Fire = fire ?? new Dice();
            Force = force ?? new Dice();
            Lightning = lightning ?? new Dice();
            Necrotic = necrotic ?? new Dice();
            Poison = poison ?? new Dice();
            Psychic = psychic ?? new Dice();
            Radiant = radiant ?? new Dice();
            Thunder = thunder ?? new Dice();

            // Pre-roll values for efficiency
            HealC = Heal.Roll(true);
            PierceC = Pierce.Roll(true);
            BluntC = Blunt.Roll(true);
            SlashC = Slash.Roll(true);
            AcidC = Acid.Roll(true);
            ColdC = Cold.Roll(true);
            FireC = Fire.Roll(true);
            ForceC = Force.Roll(true);
            LightningC = Lightning.Roll(true);
            NecroticC = Necrotic.Roll(true);
            PoisonC = Poison.Roll(true);
            PsychicC = Psychic.Roll(true);
            RadiantC = Radiant.Roll(true);
            ThunderC = Thunder.Roll(true);
        }



        public Dice Pierce { get; set;}
        public Dice Blunt { get; set;}
        public Dice Slash { get; set;}
        public Dice Heal { get; set;}
        public Dice Acid { get; set;}
        public Dice Cold { get; set;}
        public Dice Fire { get; set;}
        public Dice Force { get; set;}
        public Dice Lightning { get; set;}
        public Dice Necrotic { get; set;}
        public Dice Poison { get; set;}
        public Dice Psychic { get; set;}
        public Dice Radiant { get; set;}
        public Dice Thunder { get; set;}

        // gleda dali ima ikoju kocku pod tim tipom
        private int PierceC = 0;
        private int BluntC = 0;
        private int SlashC = 0;
        private int HealC = 0;
        private int AcidC = 0;
        private int ColdC = 0;
        private int FireC = 0;
        private int ForceC = 0;
        private int LightningC = 0;
        private int NecroticC = 0;
        private int PoisonC = 0;
        private int PsychicC = 0;
        private int RadiantC = 0;
        private int ThunderC = 0;

        public int Attack(ACreature enemy, bool Is_Mage = false) {
            int totalDamage = 0;
            if(!Is_Mage){  
                if (HealC != 0) {
                    totalDamage += (int)(Heal.Roll(Settings.isComplex) * enemy.RES_Heal);
                }
                if (PierceC != 0) {
                    totalDamage += (int)(Pierce.Roll(Settings.isComplex) * enemy.RES_Pierce);
                }
                if (BluntC != 0) {
                    totalDamage += (int)(Blunt.Roll(Settings.isComplex) * enemy.RES_Blunt);
                }
                if (SlashC != 0) {
                    totalDamage += (int)(Slash.Roll(Settings.isComplex) * enemy.RES_Sharp);
                }
                if (AcidC != 0) {
                    totalDamage += (int)(Acid.Roll(Settings.isComplex) * enemy.RES_Acid);
                }
                if (ColdC != 0) {
                    totalDamage += (int)(Cold.Roll(Settings.isComplex) * enemy.RES_Cold);
                }
                if (FireC != 0) {
                    totalDamage += (int)(Fire.Roll(Settings.isComplex) * enemy.RES_Fire);
                }
                if (ForceC != 0) {
                    totalDamage += (int)(Force.Roll(Settings.isComplex) * enemy.RES_Force);
                }
                if (LightningC != 0) {
                    totalDamage += (int)(Lightning.Roll(Settings.isComplex) * enemy.RES_Lightning);
                }
                if (NecroticC != 0) {
                    totalDamage += (int)(Necrotic.Roll(Settings.isComplex) * enemy.RES_Necrotic);
                }
                if (PoisonC != 0) {
                    totalDamage += (int)(Poison.Roll(Settings.isComplex) * enemy.RES_Poison);
                }
                if (PsychicC != 0) {
                    totalDamage += (int)(Psychic.Roll(Settings.isComplex) * enemy.RES_Psychic);
                }
                if (RadiantC != 0) {
                    totalDamage += (int)(Radiant.Roll(Settings.isComplex) * enemy.RES_Radiant);
                }
                if (ThunderC != 0) {
                    totalDamage += (int)(Thunder.Roll(Settings.isComplex) * enemy.RES_Thunder);
                }
            }
            else {
                if (HealC != 0) {
                    totalDamage += (int)(Heal.Roll(Settings.isComplex) * enemy.M_RES_Heal);
                }
                if (PierceC != 0) {
                    totalDamage += (int)(Pierce.Roll(Settings.isComplex) * enemy.M_RES_Pierce);
                }
                if (BluntC != 0) {
                    totalDamage += (int)(Blunt.Roll(Settings.isComplex) * enemy.M_RES_Blunt);
                }
                if (SlashC != 0) {
                    totalDamage += (int)(Slash.Roll(Settings.isComplex) * enemy.M_RES_Sharp);
                }
                if (AcidC != 0) {
                    totalDamage += (int)(Acid.Roll(Settings.isComplex) * enemy.M_RES_Acid);
                }
                if (ColdC != 0) {
                    totalDamage += (int)(Cold.Roll(Settings.isComplex) * enemy.M_RES_Cold);
                }
                if (FireC != 0) {
                    totalDamage += (int)(Fire.Roll(Settings.isComplex) * enemy.M_RES_Fire);
                }
                if (ForceC != 0) {
                    totalDamage += (int)(Force.Roll(Settings.isComplex) * enemy.M_RES_Force);
                }
                if (LightningC != 0) {
                    totalDamage += (int)(Lightning.Roll(Settings.isComplex) * enemy.M_RES_Lightning);
                }
                if (NecroticC != 0) {
                    totalDamage += (int)(Necrotic.Roll(Settings.isComplex) * enemy.M_RES_Necrotic);
                }
                if (PoisonC != 0) {
                    totalDamage += (int)(Poison.Roll(Settings.isComplex) * enemy.M_RES_Poison);
                }
                if (PsychicC != 0) {
                    totalDamage += (int)(Psychic.Roll(Settings.isComplex) * enemy.M_RES_Psychic);
                }
                if (RadiantC != 0) {
                    totalDamage += (int)(Radiant.Roll(Settings.isComplex) * enemy.M_RES_Radiant);
                }
                if (ThunderC != 0) {
                    totalDamage += (int)(Thunder.Roll(Settings.isComplex) * enemy.M_RES_Thunder);
                }
            }
            enemy.Attack(totalDamage);
            return totalDamage;
        }

    }
}
