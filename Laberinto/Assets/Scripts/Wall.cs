using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour, IInteractable
{
    public void Interact()
    {
         gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    } 
}
