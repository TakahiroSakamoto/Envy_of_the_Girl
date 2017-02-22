using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private GameObject animationCamera;
    [SerializeField] private GameObject Door;

    private void Awake()
    {
        Door.GetComponent<AudioSource>().enabled = false;

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animationCamera.name)
        {
            Door.GetComponent<Animator>().SetBool("IsOpen",true);
            Invoke("StartAudio", 3.0f);
        }

    }

    void StartAudio()
    {
        Door.GetComponent<AudioSource>().enabled = true;
    }
}
