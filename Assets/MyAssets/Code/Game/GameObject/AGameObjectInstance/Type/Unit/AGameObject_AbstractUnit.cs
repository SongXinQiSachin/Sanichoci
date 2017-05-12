using Sanichoci.Game.Ability;
using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game
{
    public abstract class AGameObject_AbstractUnit :
        AbstractAGameObject,
        IUnit
    {
        private float maxHP;
        private float currentHP;
        private float maxMP;
        private float currentMP;
        private float maxSP;
        private float currentSP;

        private int strength;
        private int constitution;
        private int dexterity;
        private int intelligence;
        private int charisma;
        private int sanity;
        private int wisdom;
        private int luck;

        private float allDamageIncrementPercent;
        private float criticalPercent;
        private float meleePhysicalDamage;
        private float rangedPhysicalDamage;
        private float divineDamage;
        private float darklingDamage;
        private float elementDamage;
        private float vitalityDamage;
        private float curseDamage;
        private float iceDamage;
        private float fireDamage;
        private float lightningDamage;
        private float poisonDamage;
        private float chaosDamage;

        private float allDefenceIncrement;
        private float dodgePercent;
        private float meleePhysicalDefence;
        private float rangedPhysicalDefence;
        private float divineDefence;
        private float darklingDefence;
        private float elementDefence;
        private float vitalityDefence;
        private float curseDefence;
        private float iceDefence;
        private float fireDefence;
        private float lightningDefence;
        private float poisonDefence;
        private float chaosDefence;

        private List<IItem> items;

        private List<IAbility> abilities;

        public override AGameObjectType Type
        {
            get
            {
                return AGameObjectType.Unit;
            }
        }

        public virtual float MaxHP
        {
            get
            {
                return maxHP;
            }

            set
            {
                maxHP = value;
            }
        }

        public virtual float CurrentHP
        {
            get
            {
                return currentHP;
            }

            set
            {
                currentHP = value;
            }
        }

        public virtual float MaxMP
        {
            get
            {
                return maxMP;
            }

            set
            {
                maxMP = value;
            }
        }

        public virtual float CurrentMP
        {
            get
            {
                return currentMP;
            }

            set
            {
                currentMP = value;
            }
        }

        public virtual float MaxSP
        {
            get
            {
                return maxSP;
            }

            set
            {
                maxSP = value;
            }
        }

        public virtual float CurrentSP
        {
            get
            {
                return currentSP;
            }

            set
            {
                currentSP = value;
            }
        }

        public virtual int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public virtual int Constitution
        {
            get
            {
                return constitution;
            }

            set
            {
                constitution = value;
            }
        }

        public virtual int Dexterity
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        public virtual int Intelligence
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }

        public virtual int Charisma
        {
            get
            {
                return charisma;
            }

            set
            {
                charisma = value;
            }
        }

        public virtual int Sanity
        {
            get
            {
                return sanity;
            }

            set
            {
                sanity = value;
            }
        }

        public virtual int Wisdom
        {
            get
            {
                return wisdom;
            }

            set
            {
                wisdom = value;
            }
        }

        public virtual int Luck
        {
            get
            {
                return luck;
            }

            set
            {
                luck = value;
            }
        }

        public virtual float AllDamageIncrementPercent
        {
            get
            {
                return allDamageIncrementPercent;
            }

            set
            {
                allDamageIncrementPercent = value;
            }
        }

        public virtual float CriticalPercent
        {
            get
            {
                return criticalPercent;
            }

            set
            {
                criticalPercent = value;
            }
        }

        public virtual float MeleePhysicalDamage
        {
            get
            {
                return meleePhysicalDamage;
            }

            set
            {
                meleePhysicalDamage = value;
            }
        }

        public virtual float RangedPhysicalDamage
        {
            get
            {
                return rangedPhysicalDamage;
            }

            set
            {
                rangedPhysicalDamage = value;
            }
        }

        public virtual float DivineDamage
        {
            get
            {
                return divineDamage;
            }

            set
            {
                divineDamage = value;
            }
        }

        public virtual float DarklingDamage
        {
            get
            {
                return darklingDamage;
            }

            set
            {
                darklingDamage = value;
            }
        }

        public virtual float ElementDamage
        {
            get
            {
                return elementDamage;
            }

            set
            {
                elementDamage = value;
            }
        }

        public virtual float VitalityDamage
        {
            get
            {
                return vitalityDamage;
            }

            set
            {
                vitalityDamage = value;
            }
        }

        public virtual float CurseDamage
        {
            get
            {
                return curseDamage;
            }

            set
            {
                curseDamage = value;
            }
        }

        public virtual float IceDamage
        {
            get
            {
                return iceDamage;
            }

            set
            {
                iceDamage = value;
            }
        }

        public virtual float FireDamage
        {
            get
            {
                return fireDamage;
            }

            set
            {
                fireDamage = value;
            }
        }

        public virtual float LightningDamage
        {
            get
            {
                return lightningDamage;
            }

            set
            {
                lightningDamage = value;
            }
        }

        public virtual float PoisonDamage
        {
            get
            {
                return poisonDamage;
            }

            set
            {
                poisonDamage = value;
            }
        }

        public virtual float ChaosDamage
        {
            get
            {
                return chaosDamage;
            }

            set
            {
                chaosDamage = value;
            }
        }

        public virtual float AllDefenceIncrement
        {
            get
            {
                return allDefenceIncrement;
            }

            set
            {
                allDefenceIncrement = value;
            }
        }

        public virtual float DodgePercent
        {
            get
            {
                return dodgePercent;
            }

            set
            {
                dodgePercent = value;
            }
        }

        public virtual float MeleePhysicalDefence
        {
            get
            {
                return meleePhysicalDefence;
            }

            set
            {
                meleePhysicalDefence = value;
            }
        }

        public virtual float RangedPhysicalDefence
        {
            get
            {
                return rangedPhysicalDefence;
            }

            set
            {
                rangedPhysicalDefence = value;
            }
        }

        public virtual float DivineDefence
        {
            get
            {
                return divineDefence;
            }

            set
            {
                divineDefence = value;
            }
        }

        public virtual float DarklingDefence
        {
            get
            {
                return darklingDefence;
            }

            set
            {
                darklingDefence = value;
            }
        }

        public virtual float ElementDefence
        {
            get
            {
                return elementDefence;
            }

            set
            {
                elementDefence = value;
            }
        }

        public virtual float VitalityDefence
        {
            get
            {
                return vitalityDefence;
            }

            set
            {
                vitalityDefence = value;
            }
        }

        public virtual float CurseDefence
        {
            get
            {
                return curseDefence;
            }

            set
            {
                curseDefence = value;
            }
        }

        public virtual float IceDefence
        {
            get
            {
                return iceDefence;
            }

            set
            {
                iceDefence = value;
            }
        }

        public virtual float FireDefence
        {
            get
            {
                return fireDefence;
            }

            set
            {
                fireDefence = value;
            }
        }

        public virtual float LightningDefence
        {
            get
            {
                return lightningDefence;
            }

            set
            {
                lightningDefence = value;
            }
        }

        public virtual float PoisonDefence
        {
            get
            {
                return poisonDefence;
            }

            set
            {
                poisonDefence = value;
            }
        }

        public virtual float ChaosDefence
        {
            get
            {
                return chaosDefence;
            }

            set
            {
                chaosDefence = value;
            }
        }

        public virtual List<IItem> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public virtual List<IAbility> Abilities
        {
            get
            {
                return abilities;
            }

            set
            {
                abilities = value;
            }
        }

        public abstract void CastHP();
        public abstract void CastMP();
        public abstract void CastSP();
        public abstract bool HasEnoughHP(float cost);
        public abstract bool HasEnoughMP(float cost);
        public abstract bool HasEnoughSP(float cost);
        public abstract void UseAbility(IAbility ability);
    }
}
