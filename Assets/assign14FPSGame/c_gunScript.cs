using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class c_gunScript : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem g_muzzleFlash;
    public ParticleSystem g_hitMark;
    public Transform g_RayOrigin;
    RaycastHit g_hit;
    bool g_playHitAnimation;
    void Start()
    {
        g_playHitAnimation = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_fire();
        m_activateHitMark();
    }
    void m_fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            g_muzzleFlash.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            g_muzzleFlash.Stop();
        }
    }
    void m_activateHitMark()
    {
        if(Input.GetMouseButton(0))
        {
            //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out g_hit, 30))
            {
                g_hitMark.transform.position = g_hit.point;
                g_playHitAnimation = true;
                g_hitMark.Play();
            }
        }                
        if (Input.GetMouseButtonUp(0))g_hitMark.Stop();
    }
}
