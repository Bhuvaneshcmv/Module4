using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace breakout
{
    public class c_bricksPrefabScript : MonoBehaviour
    {
        // Start is called before the first frame update
        int g_numOfColumns;
        int g_numOfRows;
        public Transform g_brickPrefab;
        Vector3 g_initialPos;
        void Start()
        {
            g_numOfColumns = 6;
            g_numOfRows = 5;
            g_initialPos = new Vector3(-4f, 0.5f, 4f);
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
                    Instantiate(g_brickPrefab, new Vector3(g_initialPos.x + i * 1.5f, 0.5f, j * 1.5f), Quaternion.identity);
                }
            }
        }
    }
}
