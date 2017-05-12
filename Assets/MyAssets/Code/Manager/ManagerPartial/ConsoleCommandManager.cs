using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class ConsoleCommandManager : IManager
    {
        private static ConsoleCommandManager instance;

        public static ConsoleCommandManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new ConsoleCommandManager();
                }
                return instance;
            }
        }
    }
}
