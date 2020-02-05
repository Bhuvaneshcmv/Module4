using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
namespace breakout
{
    public class c_brickScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public c_inGameScript g_InGameScript;
        

        void Start()
        {
            g_InGameScript = this.gameObject.AddComponent(typeof(c_inGameScript)) as c_inGameScript;
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter()
        {
            //c_inGameScript.g_Score += 1;
            this.gameObject.SetActive(false);
        }
    }
}