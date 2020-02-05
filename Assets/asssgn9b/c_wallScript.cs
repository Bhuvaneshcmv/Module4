using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_wallScript : MonoBehaviour
{
    // Start is called before the first frame update
    int g_numOfColumns;
    int g_numOfRows;
    public Transform g_brickPrefab;       
    Vector3 g_initialPos;
    void Start()
    {
        g_numOfColumns = 4;
        g_numOfRows = 10;
        g_initialPos = new Vector3(3.85f, 0.125f, 0);
        m_crateBricks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void m_crateBricks()
    {
        for (int j = 0; j < g_numOfRows; j++)
        {
            for (int i = 0; i < g_numOfColumns; i++)
            {
                Instantiate(g_brickPrefab, new Vector3(g_initialPos.x - i*2, j*0.25f, 0), Quaternion.identity);
            }
        }
    }
}
