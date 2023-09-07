using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnPinch : MonoBehaviour
{
    public Transform LeftFingerTip;
    public Transform RightFingerTip;

    public void SpawnCubeLeft()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = LeftFingerTip.position;
        cube.transform.localScale = new Vector3(.1f, .1f, .1f);
        cube.GetComponent<MeshRenderer>().material.color = Color.red;

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        Grabbable _grabbable = cube.AddComponent<Grabbable>();
        HandGrabInteractable _handGrabInteractable = cube.AddComponent<HandGrabInteractable>();

        _handGrabInteractable.InjectOptionalPointableElement(_grabbable);
        _handGrabInteractable.InjectRigidbody(rb);
        _handGrabInteractable.InjectSupportedGrabTypes(Oculus.Interaction.Grab.GrabTypeFlags.Palm);

        PhysicsGrabbable _physicsGrabbable = cube.AddComponent<PhysicsGrabbable>();
        _physicsGrabbable.InjectRigidbody(rb);
        _physicsGrabbable.InjectGrabbable(_grabbable);
    }

    public void SpawnCubeRight()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = RightFingerTip.position;
        cube.transform.localScale = new Vector3(.1f, .1f, .1f);
        cube.GetComponent<MeshRenderer>().material.color = Color.red;

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        Grabbable _grabbable = cube.AddComponent<Grabbable>();
        HandGrabInteractable _handGrabInteractable = cube.AddComponent<HandGrabInteractable>();

        _handGrabInteractable.InjectOptionalPointableElement(_grabbable);
        _handGrabInteractable.InjectRigidbody(rb);
        _handGrabInteractable.InjectSupportedGrabTypes(Oculus.Interaction.Grab.GrabTypeFlags.Palm);

        PhysicsGrabbable _physicsGrabbable = cube.AddComponent<PhysicsGrabbable>();
        _physicsGrabbable.InjectRigidbody(rb);
        _physicsGrabbable.InjectGrabbable(_grabbable);
    }
}
