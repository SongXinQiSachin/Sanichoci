using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IProperty
    {
        int Strength { get; }               //  力量

        int Constitution { get; }           //  体质

        int Dexterity { get; }              //  敏捷

        int Intelligence { get; }           //  智力

        int Charisma { get; }               //  魅力

        int Sanity { get; }                 //  理智

        int Wisdom { get; }                 //  感知

        int Luck { get; }                   //  运气
    }
}
