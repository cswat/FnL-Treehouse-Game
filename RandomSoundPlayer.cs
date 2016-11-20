using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSoundPlayer : MonoBehaviour {
	private AudioSource audioSource;
	[SerializeField]
	private List<AudioClip> soundClips = new List<AudioClip>();
	[SerializeField]
	private float soundTimerDelay = 3f;
	private float soundTimer;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		//count up to restarting
		soundTimer = Time.deltaTime + soundTimer;

		//If the timer reachers the delay...
		if (soundTimer >= soundTimerDelay) {
		//...play a random clip from the audio list and reset the timer
			soundTimer = 0f;
			AudioClip randomSound = soundClips[Random.Range(0,soundClips.Count)];
			audioSource.PlayOneShot (randomSound);

		}//if
	}
}
