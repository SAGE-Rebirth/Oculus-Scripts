using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public static Pointer Instance;

    [HideInInspector]
    public Pointable CurrentPointable;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnDisable()
    {
        CurrentPointable.OnExit.Invoke();
    }
}
