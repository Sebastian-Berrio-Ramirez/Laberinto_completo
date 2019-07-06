using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfWorld : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        AudioSystem2D.Instance.PlayMusic(songName: "medieval_battle_loop2");
        this.gameObject.GetComponent<AudioSource>().loop = enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioSystem2D.Instance.PlaySound(resourceName: "Scream");
        }
    }
}
