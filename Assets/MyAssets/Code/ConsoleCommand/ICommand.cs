using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.ConsoleCommand
{
    public interface ICommand
    {
        string Parameter
        {
            get;
            set;
        }

        bool HasParameter
        {
            get;
        }

        void Run();
    }
}
