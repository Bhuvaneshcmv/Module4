using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_prefabScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform g_bullet;
    public Rigidbody g_bulletComponents;
    Renderer g_bulletColor;
    void Start()
    {
        g_bulletComponents.AddRelativeForce(Vector3.forward * 2000);
        g_bulletColor = GetComponent<Renderer>();
        g_bulletColor.material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
