using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game
{
    public abstract class AGameObject_AbstractItem :
        AbstractAGameObject,
        IItem
    {

        private float maxHP;

        private float currentHP;
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

        public override AGameObjectType Type
        {
            get
            {
                return AGameObjectType.Item;
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

        public abstract ItemType ItemType { get; }
    }
}
