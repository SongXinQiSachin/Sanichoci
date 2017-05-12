using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Animation
{
    public interface IAnimation
    {
        void OnStart();
        void OnUpdate();
        void OnFinish();
    }
}
