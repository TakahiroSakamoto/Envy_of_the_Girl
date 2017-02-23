using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private GameObject animationCamera;
    [SerializeField] private GameObject Door;
    [SerializeField] private AudioClip openDoor;
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = Door.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animationCamera.name)
        {
           // Door.GetComponent<Animator>().SetBool("IsOpen",true);
            _audioSource.clip = openDoor;
            _audioSource.PlayOneShot(_audioSource.clip);
        }

    }


}
