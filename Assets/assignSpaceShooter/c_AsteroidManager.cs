using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_AsteroidManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> g_asteroidList = new List<GameObject>();
    Vector3 g_initialPos;
    void Start()
    {
        InvokeRepeating("m_initiateAsteroids", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void m_initiateAsteroids()
    {
        g_initialPos = new Vector3(Random.Range(-100, 100), 100 * 16 / 9, 0);
        Instantiate(g_asteroidList[Mathf.RoundToInt(Random.Range(0, 2.4f))],g_initialPos, Quaternion.identity);
    }
}
