using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace assign8
{
    public class c_screenSwitchScript1 : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject g_HomePanel;
        public GameObject g_settingsMenuPanel;
        public Toggle g_toggleComponent;

        void Start()
        {
            //g_toggleComponent = g_ToggleButton.GetComponent<Toggle>();
            m_goToHomeMenu();
            m_SetToggleValue();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void m_goToSolarSystemScene()
        {
            SceneManager.LoadScene("solarSystem");
        }
        public void m_goToMainMenuScene()
        {
            SceneManager.LoadScene("main menu1");
        }

        public void m_goToHomeMenu()
        {
            g_HomePanel.SetActive(true);
            g_settingsMenuPanel.SetActive(false);
        }
        public void m_goToSettingsMenu()
        {
            g_HomePanel.SetActive(false);
            g_settingsMenuPanel.SetActive(true);
        }
        public void m_LoadToggleValue()
        {
            if (g_toggleComponent.isOn == false)
            {
                PlayerPrefs.SetInt("SolarSystem", 0);
            }
            else
            {
                PlayerPrefs.SetInt("SolarSystem", 1);
            }
        }
        public void m_SetToggleValue()
        {
            if (PlayerPrefs.GetInt("SolarSystem") == 0)
            {
                g_toggleComponent.isOn = false;
            }
            else
            {
                g_toggleComponent.isOn = true;
            }
        }

        public void m_changeToggleValue()
        {
            if (PlayerPrefs.GetInt("SolarSystem") == 0)
            {
                PlayerPrefs.SetInt("SolarSystem", 1);
            }
            else
            {
                PlayerPrefs.SetInt("SolarSystem", 0);
            }
        }
    }
}