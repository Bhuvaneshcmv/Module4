using UnityEngine;

namespace Assign5c
{
    public class c_spriteManager : MonoBehaviour
    {
        public MeshFilter g_meshFilter;
        Mesh g_mesh;

        [SerializeField]
        Vector2[] g_UV;
        // Start is called before the first frame update
        void Start()
        {
            g_mesh = g_meshFilter.mesh;
            g_UV = g_mesh.uv;
            m_updateUV();
        }

        // Update is called once per frame
        void Update()
        {
            m_manageInput();
        }

        void m_manageInput()
        {
            
            if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
            {
                
                for (int i = 0; i < g_UV.Length; i++)
                {
                    g_UV[i].x += 0.1f;
                }
                g_mesh.uv = g_UV;
            }
        }

        void m_updateUV()
        {
            for(int i=0;i<g_UV.Length;i++)
            {
                g_UV[i].x *= 0.1f;
            }
            g_mesh.uv = g_UV;
        }
    }

}
