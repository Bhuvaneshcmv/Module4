using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assign3
{
    public class c_Cube : MonoBehaviour
    {
        // Start is called before the first frame update

        Vector3 g_position;
        Vector3 g_scale;
        int g_moveSpeed = 5;
        int g_xAngle;
        int g_yAngle;
        int g_zAngle;
        bool g_rotateRight;
        bool g_rotateLeft;
        bool g_rotateUp;
        bool g_rotateDown;
        bool g_increaseSize;
        bool g_decreaseSize;

        void Start()
        {
            g_position = Vector3.zero;
            g_xAngle = 0;
            g_yAngle = 0;
            g_rotateRight = false;
            g_rotateLeft = false;
            g_rotateUp = false;
            g_rotateDown = false;
            g_increaseSize = false;
            g_decreaseSize = false;
            g_scale = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
            m_inputHandler();
            m_move();
            m_rotateHandler();
            m_rotate();
            m_scale();
        }

        void m_move()
        {
            this.transform.Translate(g_position * Time.deltaTime * g_moveSpeed, Space.Self);
        }
        void m_rotateHandler()
        {
            g_xAngle = 0;
            g_yAngle = 0;
            if (g_rotateRight)
            {
                g_xAngle++;
            }
            if (g_rotateLeft)
            {
                g_xAngle--;
            }
            if (g_rotateUp)
            {
                g_yAngle++;
            }
            if (g_rotateDown)
            {
                g_yAngle--;
            }
        }
        void m_rotate()
        {
            this.transform.Rotate(g_xAngle, g_yAngle, g_zAngle);
        }
        void m_scale()
        {
            this.transform.localScale += g_scale;
        }
        void m_inputHandler()
        {
            g_position.x = Input.GetAxis("Horizontal");
            g_position.z = Input.GetAxis("Vertical");
            g_scale = Vector3.zero;
            if (Input.GetKey(KeyCode.D))
            {
                g_rotateRight = true;
            }
            else
            {
                g_rotateRight = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                g_rotateLeft = true;
            }
            else
            {
                g_rotateLeft = false;
            }
            if (Input.GetKey(KeyCode.W))
            {
                g_rotateUp = true;
            }
            else
            {
                g_rotateUp = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                g_rotateDown = true;
            }
            else
            {
                g_rotateDown = false;
            }
            if (Input.GetKey(KeyCode.I))
            {
                g_scale.x = 0.1f;
                g_scale.y = 0.1f;
                g_scale.z = 0.1f;
            }
            if (Input.GetKey(KeyCode.O))
            {
                g_scale.x = -0.1f;
                g_scale.y = -0.1f;
                g_scale.z = -0.1f;
            }
        }

    }
}
