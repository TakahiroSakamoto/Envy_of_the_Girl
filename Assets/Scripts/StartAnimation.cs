using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject animCamera;
    [SerializeField] private GameObject doll;
    [SerializeField] private GameObject isZombi;


    private void Awake()
    {
        anim = doll.GetComponent<Animator>();
        anim.enabled = false;
    }

    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == animCamera.name)
        {
            anim.enabled = true;
            isZombi.SetActive(true);

        }
    }
}
