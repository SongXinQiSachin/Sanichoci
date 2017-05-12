using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game.Interface
{
    public interface IDescribable
    {
        string Name { get; }
        string Description { get; }
    }
}
