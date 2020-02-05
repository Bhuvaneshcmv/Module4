using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_cameraScript: MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 g_pos;
    bool g_shoot;
    public GameObject g_bullet;
    GameObject g_bulletClone;
    
    void Start()
    {
        g_pos = Vector3.zero;
        g_shoot = false;
        InvokeRepeating("m_forwardMotion", 2, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        m_inputManager();
        m_shoot();
        
    }
    
    void m_inputManager()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x >= -10)
        {
            this.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow) && this.transform.position.x <= 10)
        {
            this.transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            g_shoot = true;
        }

    }
    void m_forwardMotion()
    {
        this.transform.Translate(Vector3.forward);
    }
    void m_shoot()
    {
        if (g_shoot)
        {
            g_shoot = false;
            g_bulletClone = Instantiate(g_bullet, transform.position, Quaternion.identity);

        }
        Destroy(g_bulletClone,1);
    }
}
