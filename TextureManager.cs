using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureManager : MonoBehaviour
{
    public GameObject startObject;
    GameObject currentObject;
    // Start is called before the first frame update
    void Start()
    {
        currentObject = startObject;
    }

    public void SelectObject(GameObject obj)
    {
        currentObject = obj;
    }

    public void AssignTexture(Texture texture)
    {
        currentObject.GetComponent<MeshRenderer>().material.mainTexture = texture;
    }
}
