using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : Monobehaviour{
	public AudioClip musicClip;
	public AudioSource musicSource;

	void Start() {
		MusicSource.clip = MusicClip;
	}

	void Update() {
		if(Input.GetKeyDown(Keycode.Space))
		  MusicSource.Play();
	}
}