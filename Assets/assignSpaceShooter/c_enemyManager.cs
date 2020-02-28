using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_enemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject g_EnemyPrefab;
    Vector3 g_initialPos;
    void Start()
    {
        InvokeRepeating("m_chooseInitialPos", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void m_chooseInitialPos()
    {
        g_initialPos = new Vector3(Random.Range(-100, 100), 100 * 16 / 9, 0);
        Instantiate(g_EnemyPrefab, g_initialPos, Quaternion.identity);
    }
}
