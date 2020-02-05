using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace breakout
{
    public class c_inGameScript : MonoBehaviour
    {
        public Text g_ScoreText;
        public static int g_Score;
        string  g_scoreString;
        public AudioClip g_collisonSound;
        
        void Start()
        {
            g_Score = 0;
        }
        void Update()
        {
            m_PrintScore();
        }
        public void m_goToMainMenu()
        {
            SceneManager.LoadScene("breakoutMainMenu");
        }
        public void m_PrintScore()
        {
            g_scoreString = g_Score.ToString();
            //g_ScoreText.text = g_scoreString;
        }
    }
}
