using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;


	void Awake() {
		DontDestroyOnLoad(gameObject);
	}


	void Start() {
		audioSource = GetComponent<AudioSource>();
		SceneManager.sceneLoaded += PlayLevelMusic;
	}
		

	void PlayLevelMusic(Scene scene, LoadSceneMode loadSceneMode) {
		AudioClip thisLevelMusic = levelMusicChangeArray[scene.buildIndex];

		if (thisLevelMusic) {
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}


}