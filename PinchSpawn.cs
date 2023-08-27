using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchSpawn : MonoBehaviour
{
    public Transform fingertipLeft;
    public Transform fingertipRight;

    public void spawnCubeLeft()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
        cube.transform.position = fingertipLeft.position;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        Grabbable grabbable = cube.AddComponent<Grabbable>();
        HandGrabInteractable handGrabInteractable = cube.AddComponent<HandGrabInteractable>();
        PhysicsGrabbable physicsGrabbable = cube.AddComponent<PhysicsGrabbable>();

        handGrabInteractable.InjectRigidbody(rb);
        handGrabInteractable.InjectOptionalPointableElement(grabbable);
        handGrabInteractable.InjectSupportedGrabTypes(Oculus.Interaction.Grab.GrabTypeFlags.Palm);

        physicsGrabbable.InjectGrabbable(grabbable);
        physicsGrabbable.InjectRigidbody(rb);
    }

    public void spawnCubeRight()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        cube.transform.position = fingertipRight.position;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        Grabbable grabbable = cube.AddComponent<Grabbable>();
        HandGrabInteractable handGrabInteractable = cube.AddComponent<HandGrabInteractable>();
        PhysicsGrabbable physicsGrabbable = cube.AddComponent<PhysicsGrabbable>();

        handGrabInteractable.InjectRigidbody(rb);
        handGrabInteractable.InjectOptionalPointableElement(grabbable);
        handGrabInteractable.InjectSupportedGrabTypes(Oculus.Interaction.Grab.GrabTypeFlags.Palm);

        physicsGrabbable.InjectGrabbable(grabbable);
        physicsGrabbable.InjectRigidbody(rb);
    }
}
