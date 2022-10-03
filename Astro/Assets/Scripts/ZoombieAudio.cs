using System.Collections;
using UnityEngine;

public class ZoombieAudio : MonoBehaviour {

    public AudioClip[] audio;
    private AudioSource audioSource;
    public float timeToWait = 3f;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(spawnAudio());
    }

    IEnumerator spawnAudio() {
        while(true) {
            yield return new WaitForSeconds(timeToWait);
            AudioClip nowAudio = audio[Random.Range(0, audio.Length)];
            audioSource.clip = nowAudio;
            audioSource.Play();
        }
    }

}
