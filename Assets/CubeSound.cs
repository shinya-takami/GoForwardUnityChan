using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    public AudioClip sound;

    // キューブのPrefab
    public GameObject cubePrefab;

    void Start() { }


    void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}