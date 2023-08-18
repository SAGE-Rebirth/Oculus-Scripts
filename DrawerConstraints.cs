using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerConstraints : MonoBehaviour
{
    Quaternion initialRotation;
    // Start is called before the first frame update
    void Start()
    {
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = initialRotation;
        if(transform.localPosition.y < 0.014f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 0.014f, transform.localPosition.z);
        }

        else if(transform.localPosition.y > 0.5f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 0.5f, transform.localPosition.z);
        }
    }
}
