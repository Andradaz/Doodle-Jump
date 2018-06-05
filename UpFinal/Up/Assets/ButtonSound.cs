using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {
    public AudioSource source;
    public AudioClip hover;

    public void Onhover()
    {
        source.PlayOneShot(hover);
    }
}
