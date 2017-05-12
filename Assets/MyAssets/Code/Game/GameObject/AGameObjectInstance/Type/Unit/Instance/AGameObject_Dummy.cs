using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Sanichoci.Game.Ability;

namespace Sanichoci.Game.AGameObjectInstance
{
    public class AGameObject_Dummy : AGameObject_AbstractUnit
    {

        public override GameObject Prefab
        {
            get
            {
                return PrefabManager.Instance.Dummy;
            }
        }
        public AGameObject_Dummy()
        {

            Name = "Dummy";
            Description = "This is a Dummy";
            MaxHP = 100;
            CurrentHP = 100;
            MaxMP = 100;
            CurrentMP = 100;
            MaxSP = 10;
            CurrentSP = 10;
        }

        public override void CastHP()
        {
            throw new NotImplementedException();
        }

        public override void CastMP()
        {
            throw new NotImplementedException();
        }

        public override void CastSP()
        {
            throw new NotImplementedException();
        }

        public override bool HasEnoughHP(float cost)
        {
            throw new NotImplementedException();
        }

        public override bool HasEnoughMP(float cost)
        {
            throw new NotImplementedException();
        }

        public override bool HasEnoughSP(float cost)
        {
            throw new NotImplementedException();
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
