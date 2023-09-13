using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VRShoot : MonoBehaviour
{
    public SimpleShoot simpleShoot;
    public OVRInput.Button shootButton;
    public float vibrationDuration = 0.1f;

    OVRGrabbable ovrGrabbable;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed && OVRInput.GetDown(shootButton,ovrGrabbable.grabbedBy.GetController()))
        {
            simpleShoot.ShootBullet();
            audioSource.Play();
            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(0.2f);
        OVRInput.SetControllerVibration(1, 1, ovrGrabbable.grabbedBy.GetController());
        StartCoroutine(VibrationDuration(vibrationDuration));
    }

    IEnumerator VibrationDuration(float Duration)
    {
        yield return new WaitForSeconds(Duration);
        OVRInput.SetControllerVibration(0, 0, ovrGrabbable.grabbedBy.GetController());
    }
}
