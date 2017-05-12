using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class GameManager : IManager
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }
        private GameManager()
        {
        }
    }
}
