using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    private AudioClip _explosionAudio;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {    
        _audioSource = GetComponent<AudioSource>();

       Destroy(this.gameObject, 3.0f); 
       _audioSource.Play();
    }
}
