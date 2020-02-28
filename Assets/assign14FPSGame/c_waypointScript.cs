using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_waypointScript : MonoBehaviour
{
    public bool g_activate;
    // Start is called before the first frame update
    void Start()
    {
        g_activate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            this.g_activate = true;
        }
    }
}
