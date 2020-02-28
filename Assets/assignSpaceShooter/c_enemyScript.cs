using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spaceShooter
{
    public class c_enemyScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public Transform g_player;
        void Start()
        {
            
        }
        
        // Update is called once per frame
        void Update()
        {
            Vector3 l_directionToPlayer = g_player.position - this.transform.position;
            this.transform.Translate(0, -100 * Time.deltaTime, 0,Space.World);
            this.transform.rotation = Quaternion.LookRotation(Vector3.forward,l_directionToPlayer);
            if(this.transform.position.y <= -100 * 16 / 9)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
