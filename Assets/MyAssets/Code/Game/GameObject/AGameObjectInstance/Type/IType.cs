using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IType
    {
        AGameObjectType Type
        {
            get;
        }
    }

    public enum AGameObjectType
    {
        None,
        Unit,
        Building,
        Terrain,
        Decoration,
        Item
    }
}
