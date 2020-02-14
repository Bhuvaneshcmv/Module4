using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assign12a
{
    public class c_selectObjectScript : MonoBehaviour
    {
        public GameObject g_capsule;
        public GameObject g_sphere;
        public GameObject g_cube;
        RaycastHit g_obj;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            m_checkMousePosAndGiveOutput();
        }
        void m_checkMousePosAndGiveOutput()
        {
            if(Input.GetMouseButtonDown(0))
            {
               Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                
               if(Physics.Raycast(ray, out g_obj,100))
                {
                    print(g_obj.collider.name);
                }
                
            }
        }
    }
}
