using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_anotherCubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 g_Position;
    bool g_rotate;
    int g_rotationSpeed = 360;
    Renderer g_rend;
    void Start()
    {
        g_Position = Vector3.zero;
        g_rotate = false;
        g_rend = GetComponent<Renderer>();
        g_rend.material.color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        m_rotate();
    }
    
    void m_rotate()
    {
        if(g_rotate)
        {
            this.transform.Rotate(Vector3.up*Time.deltaTime*g_rotationSpeed, Space.Self);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        g_rotate = true;
        g_rend.material.color = Color.blue;
    }
}
