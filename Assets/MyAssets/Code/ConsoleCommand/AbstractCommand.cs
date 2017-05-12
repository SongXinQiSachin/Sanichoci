using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.UI;

namespace Sanichoci.ConsoleCommand
{
    public abstract class AbstractCommand : ICommand
    {
        private bool hasParameter;
        private string parameter;

        public AbstractCommand()
        {
            Parameter = "";
        }

        public AbstractCommand(string parameter)
        {
            Parameter = parameter;
        }

        public abstract void Run();

        public string Parameter
        {
            get
            {
                return parameter;
            }

            set
            {
                parameter = value;
                hasParameter = parameter.Length > 0;
            }
        }

        public bool HasParameter
        {
            get
            {
                return hasParameter;
            }
        }


        protected void ShowMessage(string msg)
        {
            ConsoleCommandManager.Instance.ShowConsoleMessage(msg);
        }
    }
}
