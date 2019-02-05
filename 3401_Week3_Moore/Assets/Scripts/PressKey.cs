using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressKey : MonoBehaviour {

    public Animator anim;
    public AudioSource audioToPlay;
    public Slider volume;

    void Update()
    {
        audioToPlay.volume = volume.value;
    }

    public void PressDown()
    {
        anim.SetTrigger("press");
        anim.Play("KeyUp");
        audioToPlay.Play();
        print("Clicked!");
    }
}
