using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IItem : 
        IAGameObject,
        IDescribable,
        IType, IItemType,
        IHP,
        IDefenceState
    {
    }
}
