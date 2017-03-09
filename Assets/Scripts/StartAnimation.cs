using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject animCamera;
    [SerializeField] private GameObject doll;
    [SerializeField] private GameObject isZombi;

    [SerializeField] private GameObject isZombi2;
    //[SerializeField] private GameObject IsZombiDash;

    private GvrHead turnOn;


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
        turnOn = animCamera.GetComponent<GvrHead>();
        if (other.gameObject.name == animCamera.name)
        {
            anim.enabled = true;
            isZombi.SetActive(true);
            isZombi2.SetActive(true);
            OnTurn();

//        } else if (other.collider.gameObject.name == isZombi.gameObject.name)
//        {
//            Destroy(doll);
//            print("人形削除");
//        } else if (other.collider.gameObject.name == isZombi2.gameObject.name)
//        {
//            isZombi.SetActive(true);
        }
    }

    void OnTurn()
    {
        turnOn.trackRotation = false;
        print("UnGyaro");
    }
}
