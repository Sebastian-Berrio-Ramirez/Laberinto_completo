using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor : MonoBehaviour, IInteractable
{
    bool pared = false;
    float counter;
  public void Interact()
  {
      gameObject.SetActive(pared);
      ////counter+=Time.deltaTime;
        //Debug.Log(counter);
        if (pared == false)
        {
            counter += Time.deltaTime;
            Debug.Log(counter);

            if (counter == 3)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
           
  }
}
