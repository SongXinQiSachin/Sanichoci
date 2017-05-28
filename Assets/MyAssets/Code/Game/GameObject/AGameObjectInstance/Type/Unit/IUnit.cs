using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IUnit : 
        IAGameObject,
        IDescribable,
        IType,
        IHP, IMP, ISP, IMPCaster, IHPCaster, ISPCaster,
        IProperty,
        IAttackState, IDefenceState, IInventory
    {
    }
}
