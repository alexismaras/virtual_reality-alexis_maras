using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAmbientAudio : MonoBehaviour
{
    [SerializeField] AudioSource birdChirp1;
    [SerializeField] AudioSource birdChirp2;
    [SerializeField] AudioSource birdChirp3;

    bool cycleActive;
    // Start is called before the first frame update
    void Start()
    {
        cycleActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cycleActive)
        {
            int randomSound = Random.Range(1, 3);
            int randomTime = Random.Range(3, 15);
            StartCoroutine(SoundCycle(randomSound, randomTime));
        }
    }

    IEnumerator SoundCycle(int sound, int time)
    {
        cycleActive = true;
        yield return new WaitForSeconds((float)time);
        if (sound== 1)
        {
            birdChirp1.Play();
        }
        else if (sound== 2)
        {
            birdChirp2.Play();
        }
        else if (sound== 3)
        {
            birdChirp3.Play();
        }
        cycleActive = false;
    }
}
