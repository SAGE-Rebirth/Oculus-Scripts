using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    public GameObject footballPrefab;
    public GameObject PressButton;
    public UnityEvent OnPress;
    public UnityEvent OnRelease;

    private GameObject m_Pressor;
    private AudioSource m_AudioSource;
    private bool m_IsPressed;


    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_IsPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!m_IsPressed)
        {
            PressButton.transform.localPosition = new Vector3(0, 0.03f, 0);
            m_Pressor = other.gameObject;
            OnPress.Invoke();
            m_AudioSource.Play();
            m_IsPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == m_Pressor)
        {
            PressButton.transform.localPosition = new Vector3(0, 0.015f, 0);
            OnRelease.Invoke();
            m_IsPressed = false;
        }
    }

    public void SpawnFootBall()
    {
        GameObject ball = Instantiate(footballPrefab);
        ball.transform.localPosition = new Vector3(0, 1, 3);
    }

}
