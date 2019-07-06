using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.transform.position = new Vector3(-34.66f, 3.90625f, 14.43f);
    }
}
