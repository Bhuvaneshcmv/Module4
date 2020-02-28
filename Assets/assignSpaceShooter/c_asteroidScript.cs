using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_asteroidScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_move();
    }

    void m_move()
    {
        this.transform.Translate(0, -100 * Time.deltaTime, 0, Space.World);
        if (this.transform.position.y<=-100*16/9)
        {
            Destroy(this.gameObject);
        }
    }
}
