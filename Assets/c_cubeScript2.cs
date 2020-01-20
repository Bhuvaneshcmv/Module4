using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign4b
{
    public class c_cubeScript2 : MonoBehaviour
    {
        c_myExScript g_myExScript;
        // Start is called before the first frame update
        void Start()
        {
            g_myExScript = this.gameObject.AddComponent(typeof(c_myExScript)) as c_myExScript;
            print(g_myExScript.g_age);
            g_myExScript.m_printBla();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
