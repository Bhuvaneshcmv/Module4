using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign7b
{
    public class c_explosionScript : MonoBehaviour
    {
        // Start is called before the first frame update
        GameObject g_sphereObject;
        float g_targetTime;
        public ParticleSystem g_particleSystem;
        void Start()
        {
            g_sphereObject = GameObject.Find("Sphere");
            g_targetTime = 0;
        }

        // Update is called once per frame
        void Update()
        {
            m_inputManager(); 
        }
        
        void m_inputManager()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                print("Space is pressed");
                g_sphereObject.SetActive(false);
                g_particleSystem.Emit(1000);
                g_targetTime = Time.time + 5;
            }
        }
        
    }
}
