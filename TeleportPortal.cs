using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPortal : MonoBehaviour
{
    [SerializeField]
    Transform targetPosition;

    CharacterController characterController;

    private void OnTriggerEnter(Collider other)
    {
        characterController = other.GetComponent<CharacterController>();
        if(characterController != null )
        {
            characterController.enabled = false;
            teleport(other.transform);
            characterController.enabled = true;
            
        }
    }

    public void teleport(Transform teleportObject)
    {
        teleportObject.position = targetPosition.position;
        teleportObject.rotation = targetPosition.rotation;

    }
}
