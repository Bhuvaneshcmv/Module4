using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace breakout
{ 
    public class c_ballScript : MonoBehaviour
    {
        Vector3 g_ballVelocity;
        int g_ballSpeed;
        public Rigidbody g_ball;
        bool g_launch = false;
        public AudioSource g_audio;
        // Start is called before the first frame update.
        void Start()
        {
            g_ballSpeed = 200;
            g_ballVelocity = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
            m_launchBall();
            m_moveBall();
        }
        void m_moveBall()
        {
            g_ball.velocity = g_ballVelocity * g_ballSpeed * Time.deltaTime;
        }
        public void m_launchBall()
        {
            if (Input.GetKeyDown(KeyCode.Space)) g_launch = true;
            if (g_launch)
            {
                g_ballVelocity = new Vector3(1, 0, 1);
                this.transform.parent = null;
                g_launch = false;
            }
        }

        private void OnCollisionEnter(Collision l_collisonStats)
        {
            //g_audio.Play();
            if (l_collisonStats.contacts[0].normal ==Vector3.left)
            {                
                g_ballVelocity.x = -g_ballVelocity.x;
                m_moveBall();

            }
            else if (l_collisonStats.contacts[0].normal == Vector3.forward)
            {   
                if (l_collisonStats.collider.name == "Plane")
                {
                    Destroy(this.gameObject);
                }
                g_ballVelocity.z = -g_ballVelocity.z;
                m_moveBall();
            }
            else if(l_collisonStats.contacts[0].normal == Vector3.right)
            {                
                g_ballVelocity.x = -g_ballVelocity.x;
                m_moveBall();
            }
            else if(l_collisonStats.contacts[0].normal == Vector3.back)
            {          
                g_ballVelocity.z = -g_ballVelocity.z;
                m_moveBall();
            }        
            else
            {
                g_ballVelocity.x = -g_ballVelocity.x;
                g_ballVelocity.z = -g_ballVelocity.z;
                m_moveBall();
            }
        }
    }
}
