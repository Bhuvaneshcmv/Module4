using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign4A
{
    public class c_cubeScript : MonoBehaviour
    {
        // Start is called before the first frame update
        c_extraScript g_extraScript;
        GameObject g_lightObject;
        void Start()
        {
            g_extraScript = GetComponent<c_extraScript>();
            g_lightObject = GameObject.Find("myFavLight");
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
                    g_extraScript.enabled = !g_extraScript.enabled;

                    if(g_lightObject.activeSelf)
                    {
                        g_lightObject.SetActive(false);
                    }
                    else
                    {
                        g_lightObject.SetActive(true);
                    }
                }
        }
    }
}
