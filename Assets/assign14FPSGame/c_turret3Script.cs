using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class c_turret3Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform g_player;
    NavMeshAgent g_turret;
    void Start()
    {
        g_turret = GetComponent<NavMeshAgent>();
        g_player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
      if(g_player.position.x < 0 && g_player.position.z<0)
        {
            g_turret.destination = g_player.position;
        }
      else
        {
            g_turret.destination = new Vector3(-50, 0, -50);
        }
    }
}
