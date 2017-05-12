using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Logic.Arithmetic
{
    public abstract class Interpolator : IInterpolator
    {
        public abstract float GetInterpolation(float input);
    }
}
