using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_moonScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 g_pos;
    void Start()
    {
        g_pos = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        m_rotate();
    }
    void m_rotate()
    {
        this.transform.Rotate(g_pos * Time.deltaTime * 5 * 30, Space.Self);

    }
}
