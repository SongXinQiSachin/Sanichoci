using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IItemType
    {
        ItemType ItemType
        {
            get;
        }
    }

    public enum ItemType
    {
        ActiveNormal,
        PassiveNormal,
        ActiveConsumables,
        PassiveConsumables
    }
}
