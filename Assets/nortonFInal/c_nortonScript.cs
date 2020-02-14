using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignNorton
{
    public class c_nortonScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public Animator g_animator;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        

        public void m_onRunBtnClick()
        {
            g_animator.SetTrigger("run");
            //g_animator.SetBool("run", false);
        }
        public void m_onDieBtnClick()
        {
            g_animator.SetTrigger("die");
            //g_animator.SetBool("die", false);
        }
        public void m_onCrouchBtnClick()
        {
            g_animator.SetTrigger("crouch");
            //g_animator.SetBool("crouch", false);
        }
        public void m_onYawnBtnClick()
        {
            g_animator.SetTrigger("yawn");
            //g_animator.SetBool("yawn", false);
        }
        public void m_onShootBtnClick()
        {
            g_animator.SetTrigger("shoot");
            //g_animator.SetBool("shoot", false);
        }
        public void m_onJumpBtnClick()
        {
            g_animator.SetTrigger("jump");
            //g_animator.SetBool("jump", false);
        }
    }
}
