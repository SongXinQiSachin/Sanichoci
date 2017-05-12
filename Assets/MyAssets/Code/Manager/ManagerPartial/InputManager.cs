using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class InputManager : IManager
    {
        private static InputManager instance;
        public static InputManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new InputManager();
                }
                return instance;
            }
        }
        private InputManager()
        {
        }
    }
}
