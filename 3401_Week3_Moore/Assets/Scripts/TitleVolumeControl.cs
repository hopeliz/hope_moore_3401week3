using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleVolumeControl : MonoBehaviour {

    public AudioSource audioToPlay;
    public Slider volume;
	
	// Update is called once per frame
	void Update () {
        audioToPlay.volume = volume.value;
	}
}
