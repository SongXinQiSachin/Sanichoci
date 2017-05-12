using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game
{
    public abstract class AbstractAGameObject :
        IAGameObject, IType,
        IDescribable,
        ILevel
    {
        public abstract GameObject Prefab { get; }

        public virtual AGameObjectType Type
        {
            get
            {
                return AGameObjectType.None;
            }
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        private string name = "Default Name";
        private string description = "Default Description";

        private int level = -1;
    }
}
