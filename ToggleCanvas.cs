using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvas : MonoBehaviour
{
    public Animator animator;
    public Transform CanvasPosition;
    bool toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            if(!toggle)
            {
                transform.position = CanvasPosition.position;
                transform.forward = CanvasPosition.forward;
            }
            
            toggle = !toggle;
            animator.SetBool("Toggle", toggle);
        }
    }
}
