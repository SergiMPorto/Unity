using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour
{

    public AudioClip explosionSound;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(explosionSound);
    }
}
