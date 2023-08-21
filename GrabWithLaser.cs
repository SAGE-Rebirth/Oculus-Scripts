using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabWithLaser : MonoBehaviour
{
    [SerializeField]
    Transform pointer;

    public bool isX;
    public bool isY;
    public bool isZ;

    public void Drag()
    {
        float _x = isX?pointer.position.x:transform.position.x;
        float _y = isY?pointer.position.y:transform.position.y;
        float _z = isZ?pointer.position.z:transform.position.z;

        transform.position = Vector3.Lerp(transform.position, new Vector3(_x, _y, _z), Time.deltaTime);
    }

}
