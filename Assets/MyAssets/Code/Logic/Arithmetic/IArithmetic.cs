using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Logic.Arithmetic
{
    public delegate void ArithmeticTimePoint();
    public delegate void ArithmeticResult(float value);
    public interface IArithmetic
    {
        void Start(ArithmeticTimePoint start, ArithmeticResult result, ArithmeticTimePoint end);

        void Pause();
        void Resume();

        void Stop();
    }
}
