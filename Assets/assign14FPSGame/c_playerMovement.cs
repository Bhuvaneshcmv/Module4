using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class c_playerMovement : MonoBehaviour
{
    public CharacterController g_player;
    Vector3 g_pos;
    int g_speed;
    int g_mouseSensitivity;
    float g_Horizontaldir;
    float g_parallelDir;
    float g_mouseX, g_mouseY;
    float g_rotPlayerX, g_rotPlayerY;
    float g_rotatePlayerX, g_rotatePlayerY;
    Vector3 g_PlayerRotation;
    Vector3 g_PlayerCameraRotate;
    float g_xLimit, g_yLimit;
    int g_gravity;
    // Start is called before the first frame update
    //[System.Obsolete]
    void Start()
    {
        g_pos = Vector3.zero;
        g_speed = 10;
        g_mouseSensitivity = 5;
        g_gravity = 100;
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        m_movePlayer();
        m_RotatePlayer();
    }
    void m_movePlayer()
    {
        if (g_player.isGrounded)
        {
            g_Horizontaldir = Input.GetAxis("Horizontal");
            g_parallelDir = Input.GetAxis("Vertical");
        }
            g_player.Move(this.transform.TransformDirection(new Vector3(g_Horizontaldir * g_speed * Time.deltaTime, -g_gravity * Time.deltaTime * Time.deltaTime, g_parallelDir * g_speed * Time.deltaTime)));
        
    }
    void m_RotatePlayer()
    {
        g_mouseX = Input.GetAxis("Mouse X");
        g_mouseY = Input.GetAxis("Mouse Y");
        g_rotPlayerX = g_mouseSensitivity * g_mouseX;
        g_rotPlayerY = g_mouseSensitivity * g_mouseY;
        g_PlayerRotation = this.transform.rotation.eulerAngles;
        g_PlayerRotation.y += g_rotPlayerX;
        g_yLimit += g_rotatePlayerX;
        g_PlayerRotation.z = 0;
        g_PlayerCameraRotate = Camera.main.transform.rotation.eulerAngles;
        g_PlayerCameraRotate.x -= g_rotPlayerY;
        g_PlayerCameraRotate.y += g_rotPlayerX;
        g_xLimit -= g_rotPlayerY;
        if(g_xLimit>=80)
        {
            g_xLimit = 80;
            g_PlayerCameraRotate.x = 80;
        }
        if(g_xLimit<=-80)
        {
            g_xLimit = -80;
            g_PlayerCameraRotate.x = -80;
        }
        this.transform.rotation = Quaternion.Euler(g_PlayerRotation);
        Camera.main.transform.rotation = Quaternion.Euler(g_PlayerCameraRotate);
    }

}
