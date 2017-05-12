using Sanichoci.Factory;
using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.ConsoleCommand
{
    public class Cmd_CreateDummy : AbstractCommand
    {
        public Cmd_CreateDummy(string parameter) : base()
        {
        }

        public override void Run()
        {
            GameObject go = AGameObjectFactory.CreateGameObjectFromGameObjectDataName("Dummy");
            go.transform.position = InputManager.Instance.GetWorldPositionFcomCursorWithRaycast(CameraManager.Instance.CurrentCamera);
        }
    }
}
