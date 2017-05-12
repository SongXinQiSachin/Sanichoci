using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class GameManager : IManager
    {
        private bool isPause = false;
        private bool isExit = false;

        public bool IsPause
        {
            get
            {
                return isPause;
            }

            set
            {
                isPause = value;
            }
        }

        public bool IsExit
        {
            get
            {
                return isExit;
            }

            set
            {
                isExit = value;
            }
        }
    }
}
