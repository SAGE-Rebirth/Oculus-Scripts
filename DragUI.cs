using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragUI : MonoBehaviour
{
    public Transform Pointer;

    [Header("Select to include in drag")]
    public bool x;
    public bool y;
    public bool z;

    public void Drag()
    {
        float _x = x ? Pointer.position.x : transform.position.x;
        float _y = y ? Pointer.position.y : transform.position.y;
        float _z = z ? Pointer.position.z : transform.position.z;
        //
        transform.position = new Vector3(_x, _y, _z);
    }
}
