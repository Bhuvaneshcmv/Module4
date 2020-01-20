using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign4b
{
    public class c_myExScript : MonoBehaviour
    {
        public int g_age;
        // Start is called before the first frame update
        void Awake()
        {
           g_age = 12;
        }
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void m_printBla()
        {
            print("foo");
        }
    }
}
