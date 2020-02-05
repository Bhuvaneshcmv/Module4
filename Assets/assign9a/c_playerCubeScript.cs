using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_playerCubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 g_playerPosition;
    int g_speed;
    Renderer g_rend;
    void Start()
    {
        g_playerPosition = Vector3.zero;
        g_speed = 5;
        g_rend = GetComponent<Renderer>();
        g_rend.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        m_inputManager();
    }

    void m_inputManager()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * g_speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * g_speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * g_speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * g_speed * Time.deltaTime, Space.World);
        }
    }
}
