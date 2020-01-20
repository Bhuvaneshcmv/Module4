using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign5
{
    public class c_cubeScript1 : MonoBehaviour
    {
        Vector3 g_pos;
        float g_moveSpeed;
        bool g_shouldMove;
        float g_seconds;
        int g_direction;
        bool g_executed;
        bool g_executedDirection;
        

        void Awake()
        {
            g_moveSpeed = 0.2f;
            g_pos = Vector3.left;
            g_shouldMove = true;
            g_seconds = 0;
            g_direction = -1;
            g_executed = false;
            g_executedDirection = false;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            m_move();
            m_timeCalculator();
        }

        void m_move()
        {
            if(g_shouldMove)this.transform.Translate(g_pos * Time.deltaTime * g_moveSpeed * g_direction , Space.Self);
        }
        void m_timeCalculator()
        {
            g_seconds = (Time.time - (Time.time%1));
            if (g_seconds % 5 == 0)
            {
                if (g_executed == false)
                {
                    g_shouldMove = !g_shouldMove;
                    if (g_seconds%10==0 && g_executedDirection == false)
                    {
                        g_direction = g_direction * -1;
                        g_executedDirection = true;
                    }
                }
                g_executed = true;
            }
            if(g_seconds%5==1)
            {
                g_executed = false;
            }
            if(g_seconds%10 == 1)
            {
                g_executedDirection = false;
            }
        }
    }
}


