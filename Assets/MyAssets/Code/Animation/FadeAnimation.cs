using Sanichoci.Kits;
using Sanichoci.Logic;
using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Animation
{
    [Obsolete("TODO", true)]
    public class FadeAnimation : IAnimation
    {
        GameObject obj;
        Renderer renderer;

        float a = 1;
        float time = 0;
        float pastTime = 0;

        public FadeAnimation(GameObject obj, float fadeoutTime)
        {
            BehaviourManager.Instance.RegisgerBehaviourProxy(BehaviourManager.Behaviour.UPDATE, OnUpdate);

            this.obj = obj;
            renderer = this.obj.GetComponent<Renderer>();

            a = renderer.material.color.a;

            time = fadeoutTime;
            pastTime = 0;

            Mesh mesh = obj.GetComponent<MeshFilter>().mesh;
            Debug.Log(mesh.vertices.Length + "/" + mesh.vertexCount + "/" + mesh.vertexBufferCount);
        }

        public void OnFinish()
        {
        }

        public void OnStart()
        {
        }

        public void OnUpdate()
        {
            if (renderer != null)
            {

                Vector2 l = Vector2.Lerp(new Vector2(0, a), new Vector2(0, 0), pastTime / time);
                a = l.y;
                renderer.material.color = new Color(1, 1, 1, a);

                pastTime += TimeKits.deltaTime();
            }
        }
    }
}
