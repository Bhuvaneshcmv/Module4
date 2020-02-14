using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_Spaceship : MonoBehaviour
{
    // Start is called before the first frame update

    int g_rotateSpeed;
    int g_moveSpeed;
    float g_dir;
    float g_angle;
    Vector3 g_pos;
    float g_angleInRadians;
    void Start()
    {
        g_rotateSpeed = 120;
        g_moveSpeed = 10;
        g_dir = 0;
        g_pos = Vector3.zero;
        g_angle = 0;
    }

    // Update is called once per frame
    void Update()
    {        
        //m_angleConversion();
        m_moveSpaceship();
    }
   
    void m_moveSpaceship()
    {
        g_dir = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.back * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.UpArrow)) this.transform.Translate(Vector3.forward * g_moveSpeed * Time.deltaTime, Space.Self);
        
        if (this.transform.position.x > 5)
        {
            this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
           for (int i=0;i>=0;i++)
            {
                this.transform.Translate(Vector3.back * g_moveSpeed * Time.deltaTime, Space.Self);
                if(this.transform.position.x <=-5||this.transform.position.y<=-5*16/9|| this.transform.position.y >= 5 * 16 / 9)
                {
                    this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
                    break;
                }
            }
        }

        if (this.transform.position.x < -5)
        {
            this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
            for (int i = 0; i >= 0; i++)
            {
                this.transform.Translate(Vector3.back * g_moveSpeed * Time.deltaTime, Space.Self);
                if (this.transform.position.x >= 5 || this.transform.position.y <= -5 * 16 / 9 || this.transform.position.y >= 5 * 16 / 9)
                {
                    this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
                    break;
                }
            }
        }
        
        if (this.transform.position.y > 5*16/9)
        {
            this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
           for (int i=0;i>=0;i++)
            {
                this.transform.Translate(Vector3.back * g_moveSpeed * Time.deltaTime, Space.Self);
                if(this.transform.position.x <=-5||this.transform.position.y<=-5*16/9|| this.transform.position.x >= 5 )
                {
                    this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
                    break;
                }
            }
        }

        if (this.transform.position.y < -5*16/9)
        {
            this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
            for (int i = 0; i >= 0; i++)
            {
                this.transform.Translate(Vector3.back * g_moveSpeed * Time.deltaTime, Space.Self);
                if (this.transform.position.x >= 5 || this.transform.position.x <= -5|| this.transform.position.y >= 5 * 16 / 9)
                {
                    this.transform.Rotate(Vector3.forward * g_dir * g_rotateSpeed * Time.deltaTime, Space.World);
                    break;
                }
            }
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "right")
        {
           
        }
    }
}
