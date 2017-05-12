using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IDefenceState
    {
        float AllDefenceIncrement { get; }

        float DodgePercent { get; }


        float MeleePhysicalDefence { get; }

        float RangedPhysicalDefence { get; }


        float DivineDefence { get; }

        float DarklingDefence { get; }


        float ElementDefence { get; }

        float VitalityDefence { get; }

        float CurseDefence { get; }


        float IceDefence { get; }

        float FireDefence { get; }

        float LightningDefence { get; }

        float PoisonDefence { get; }


        float ChaosDefence { get; }
    }
}
