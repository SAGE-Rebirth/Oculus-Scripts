using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventFunctions : MonoBehaviour
{
    public TMP_Text text;

    public void OnHover()
    {
        text.text = "Hover";
    }

    public void OnSelect()
    {
        text.text = "Selected";
    }

    public void OnRelease()
    {
        text.text = "Release";
    }

    public void OnMove()
    {
        text.text = transform.position.ToString();
    }
}
