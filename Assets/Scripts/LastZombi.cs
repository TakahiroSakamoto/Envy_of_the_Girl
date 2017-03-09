using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastZombi : MonoBehaviour
{
    [SerializeField] private GameObject animationCamera;
    [SerializeField] private GameObject lastZombi;
    [SerializeField] private GameObject fadePanel;
    private AudioSource walkAudio;

    // Use this for initialization
    void Start()
    {
        walkAudio = animationCamera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animationCamera.gameObject.name)
        {
            lastZombi.SetActive(true);
            Invoke("OnFadeOude", 1f);
            Invoke("DestroyZombi", 2.5f);
        }
    }

    void OnFadeOude()
    {
        fadePanel.SetActive(true);
    }

    void DestroyZombi()
    {
        walkAudio.enabled = false;
        lastZombi.SetActive(false);
    }
}