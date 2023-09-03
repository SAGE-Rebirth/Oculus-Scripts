using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{
    Vector3 startPosition;
    Quaternion startRotation;
    bool isKinematicInitial;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        isKinematicInitial = rb.isKinematic;
    }

    public void Reset()
    {
        rb.isKinematic = true;
        transform.position = startPosition;
        transform.rotation = startRotation;
        rb.isKinematic = isKinematicInitial;
    }
}
