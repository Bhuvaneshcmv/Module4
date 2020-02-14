using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum e_ObjName
{
    Sphere,Cube,Capsule
}

namespace assign12b
{
    public class c_moveObjectWithClicks : MonoBehaviour
    {
        public GameObject g_capsule;
        public GameObject g_sphere;
        public GameObject g_cube;
        RaycastHit g_hit;
        public Transform g_obj;
        public Vector3 g_offset;
        Vector3 g_pointOnHit;
        public bool g_objectSelected;
        Vector3 g_dragPos;
        // Start is called before the first frame update
        void Start()
        {
            g_pointOnHit = Vector3.zero;
            g_dragPos = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
            m_checkMousePosAndGiveOutput();            
        }
       
        void m_checkMousePosAndGiveOutput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out g_hit, 100))
                {
                    g_obj = g_hit.transform;
                    g_objectSelected = true;
                    g_pointOnHit = g_hit.point;
                    g_offset = g_hit.transform.position- g_pointOnHit;
                }
            }
            if(g_objectSelected)
            {
                g_dragPos.z = g_pointOnHit.z;
                g_dragPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,g_pointOnHit.z-Camera.main.transform.position.z)) ;                
                print(g_dragPos);
                //print(g_dragPos);
                g_obj.position = g_dragPos+g_offset;
            }
            if(g_objectSelected&&Input.GetMouseButtonUp(0))
            {
                g_objectSelected = false;
            }
        }
    }
}
