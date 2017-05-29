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
        public override void OnCreate()
        {
            base.OnCreate();
            Debug.Log("Create " + GetBasicName());
        }

        public sealed override AGameObjectType Type
        {
            get
            {
                return AGameObjectType.Unit;
            }
        }

        public virtual float MaxHP { get; set; }

        public virtual float CurrentHP { get; set; }

        public virtual float MaxMP { get; set; }

        public virtual float CurrentMP { get; set; }

        public virtual float MaxSP { get; set; }

        public virtual float CurrentSP { get; set; }

        public virtual int Strength { get; set; }

        public virtual int Constitution { get; set; }

        public virtual int Dexterity { get; set; }

        public virtual int Intelligence { get; set; }

        public virtual int Charisma { get; set; }

        public virtual int Sanity { get; set; }

        public virtual int Wisdom { get; set; }

        public virtual int Luck { get; set; }

        public virtual float AllDamageIncrementPercent { get; set; }

        public virtual float CriticalPercent { get; set; }

        public virtual float MeleePhysicalDamage { get; set; }

        public virtual float RangedPhysicalDamage { get; set; }

        public virtual float DivineDamage { get; set; }

        public virtual float DarklingDamage { get; set; }

        public virtual float ElementDamage { get; set; }

        public virtual float VitalityDamage { get; set; }

        public virtual float CurseDamage { get; set; }

        public virtual float IceDamage { get; set; }

        public virtual float FireDamage { get; set; }

        public virtual float LightningDamage { get; set; }

        public virtual float PoisonDamage { get; set; }

        public virtual float ChaosDamage { get; set; }

        public virtual float AllDefenceIncrement { get; set; }

        public virtual float DodgePercent { get; set; }

        public virtual float MeleePhysicalDefence { get; set; }

        public virtual float RangedPhysicalDefence { get; set; }

        public virtual float DivineDefence { get; set; }

        public virtual float DarklingDefence { get; set; }

        public virtual float ElementDefence { get; set; }

        public virtual float VitalityDefence { get; set; }

        public virtual float CurseDefence { get; set; }

        public virtual float IceDefence { get; set; }

        public virtual float FireDefence { get; set; }

        public virtual float LightningDefence { get; set; }

        public virtual float PoisonDefence { get; set; }

        public virtual float ChaosDefence { get; set; }

        public virtual List<IItem> Items { get; set; }

        public virtual List<IAbility> Abilities { get; set; }

        public abstract void CastHP();
        public abstract void CastMP();
        public abstract void CastSP();
        public abstract bool HasEnoughHP(float cost);
        public abstract bool HasEnoughMP(float cost);
        public abstract bool HasEnoughSP(float cost);
        public abstract void UseAbility(IAbility ability);
    }
}