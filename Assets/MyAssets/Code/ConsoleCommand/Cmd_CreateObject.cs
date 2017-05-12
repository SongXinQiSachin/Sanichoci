using Sanichoci.Factory;
using Sanichoci.Manager;
using Sanichoci.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.ConsoleCommand
{
    public class Cmd_CreateObject : AbstractCommand
    {
        public Cmd_CreateObject(string objectName) : base(objectName)
        {
        }

        public override void Run()
        {
            GameObject go = AGameObjectFactory.CreateGameObjectFromGameObjectDataName(Parameter);
            if (null == go)
            {
                ShowMessage("No GameObject Named \"" + Parameter + "\"");
                return;
            }
            go.transform.position = InputManager.Instance.GetWorldPositionFcomCursorWithRaycast(CameraManager.Instance.CurrentCamera);
        }
    }
}
