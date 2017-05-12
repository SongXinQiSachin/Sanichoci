using Sanichoci.ConsoleCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using UnityEngine;
using UnityEngine.UI;

namespace Sanichoci.Manager
{
    public partial class ConsoleCommandManager : IManager
    {
        private static readonly string CLASS_NAMESPACE_NAME = "Sanichoci.ConsoleCommand.Cmd_";


        public delegate void ConsoleShowMessage(string msg);
        private event ConsoleShowMessage showMessageEvent;

        private ConsoleCommandManager()
        {
            showMessageEvent += (str) => { };
        }

        public ICommand CreateCommandInstance(string cmd, string parameter)
        {
            Type type = Type.GetType(CLASS_NAMESPACE_NAME + cmd);
            ICommand result = null;
            object[] param = new object[] { parameter };

            try
            {
                result = (ICommand) Activator.CreateInstance(type, param);
            }
            catch (Exception e)
            {
                Debug.Log("Create Command Instance Error " + type);
                Debug.Log(e);
            }

            return result;
        }

        public void AddConsoleShowMessageFunc(ConsoleShowMessage func)
        {
            showMessageEvent += func;
        }

        public void ShowConsoleMessage(string msg)
        {
            showMessageEvent.Invoke(msg);
        }
    }
}
