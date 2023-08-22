using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabWithLaserInterior : MonoBehaviour
{
    [SerializeField]
    Transform pointer;
    public Transform ObjectToMove;
    public OVRPlayerController playerController;
    public bool isX;
    public bool isY;
    public bool isZ;

    public void Drag()
    {
        float _x = isX?pointer.position.x:ObjectToMove.position.x;
        float _y = isY?pointer.position.y:ObjectToMove.position.y;
        float _z = isZ?pointer.position.z:ObjectToMove.position.z;

        ObjectToMove.position = Vector3.Lerp(ObjectToMove.position, new Vector3(_x, _y, _z), Time.deltaTime);
    }

    public void Rotate()
    {
        if(OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick) != Vector2.zero )
        {
            playerController.EnableRotation = false;
            ObjectToMove.forward = new Vector3(OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x, 0, OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y);
        }
    }

    public void EnablePlayerRotation()
    {
        playerController.EnableRotation = true;
    }

}
