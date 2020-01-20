using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign5
{
    public class c_sphereScript : MonoBehaviour
    {
        // Start is called before the first frame update
        Vector3 g_pos;
        float g_presentSeconds;
        float g_targetSeconds;
        bool g_shouldRotate;
        void Start()
        {
            g_shouldRotate = true;
            g_pos = Vector3.right;
            g_targetSeconds = 20;
        }

        // Update is called once per frame
        void Update()
        {
            m_rotate();
            m_timeCalculator();
        }
        void m_rotate()
        {
            if(g_shouldRotate)this.transform.Rotate(Vector3.up, Space.Self);
        }
        void m_timeCalculator()
        {
            g_presentSeconds = Time.time - (Time.time % 1);
            print(g_presentSeconds);
            if (g_presentSeconds == g_targetSeconds)
            {
                g_shouldRotate = !g_shouldRotate;
                if (g_shouldRotate == true)
                {
                    g_targetSeconds = g_presentSeconds + 20;
                }
                if (g_shouldRotate == false)
                {
                    g_targetSeconds = g_presentSeconds + 5;
                }
            }
        }
    }
}
