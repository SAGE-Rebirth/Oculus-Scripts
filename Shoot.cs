using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public SimpleShoot simpleShoot;
    public OVRInput.Button ShootButton;

    private OVRGrabbable m_Grababble;
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_Grababble = GetComponent<OVRGrabbable>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Grababble.isGrabbed && OVRInput.GetDown(ShootButton, m_Grababble.grabbedBy.GetController()))
        {
            simpleShoot.StartShooting();
            m_AudioSource.Play();
        }
    }
}
