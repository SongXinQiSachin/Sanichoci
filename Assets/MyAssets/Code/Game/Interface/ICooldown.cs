using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game.Interface
{
    public interface ICooldown
    {
        float Cooldown { get; set; }
        float CooldownRemain { get; set; }
    }
}
