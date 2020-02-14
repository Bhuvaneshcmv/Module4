using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assign13
{
    public class c_CharacterControl : MonoBehaviour
    {
        // Start is called before the first frame update
        public CharacterController g_charactercontrol;
        float g_horizontalMovement,g_zAxisMovement;
        int g_speed, g_gravity;
        Vector3 g_movement;
        void Start()
        {
            g_horizontalMovement = 0;
            g_zAxisMovement = 0;
            g_speed = 5;
            g_gravity = 100;
            g_movement = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
            m_move();
        }
        void m_move()
        {
            g_horizontalMovement = Input.GetAxis("Horizontal");
            g_zAxisMovement = Input.GetAxis("Vertical");

            if (g_charactercontrol.isGrounded)
            {
                g_movement.x = g_horizontalMovement * g_speed;
                g_movement.z = g_zAxisMovement * g_speed;
            }
            else g_movement.y = -g_gravity*Time.deltaTime;

            g_charactercontrol.Move(g_movement * Time.deltaTime);
        }
    }
}