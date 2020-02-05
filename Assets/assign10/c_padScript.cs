using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace breakout
{
    public class c_padScript : MonoBehaviour
    {
        // Start is called before the first frame update
        Vector3 g_padPos;
        public GameObject g_ball;
        int g_padSpeed;
        float g_dir;

        void Start()
        {
            g_padPos = Vector3.zero;
            g_padSpeed = 10;
            g_dir = 0;
        }

        // Update is called once per frame
        void Update()
        {
            m_paddleMmovement();
        }

        void m_paddleMmovement()
        {
            g_dir = Input.GetAxis("Horizontal");
            g_padPos.x = Time.deltaTime * g_dir * g_padSpeed;
            this.transform.Translate(g_padPos, Space.World);
            if (this.transform.position.x >= 3.75f) this.transform.position = new Vector3(3.75f, 0.5f, -4);
            if (this.transform.position.x <= -3.75f) this.transform.position = new Vector3(-3.75f, 0.5f, -4);

        }
    }
}

