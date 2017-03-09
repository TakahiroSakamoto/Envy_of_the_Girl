using System.Collections;
using System.Collections.Generic;
//using UnityEditor.iOS.Xcode;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    //[SerializeField] private GameObject animationCamera;
    private GvrHead turnOn;

    [SerializeField] private GameObject[] turnPoint;
    [SerializeField] private GameObject batParticle;

    [SerializeField] private GameObject isDollCollider;


	// Use this for initialization
	void Start ()
	{

	}


	// Update is called once per frame
	void Update ()
	{
	    //turnOn.GetComponent<GvrHead>().trackRotation = true;
	}

    private void OnCollisionEnter(Collision other)
    {
        turnOn = GetComponent<GvrHead>();

        if (other.collider.gameObject.name == turnPoint[0].gameObject.name)
        {
            OnTurn();
            print("~~~~~~~~");
        } else if (other.collider.gameObject.name == turnPoint[1].gameObject.name)
        {
            OnTurn();
            print("OK");

        } else if (other.collider.gameObject.name == turnPoint[2].gameObject.name)
        {
            OnTurn();
        } else if (other.collider.gameObject.name == turnPoint[3].gameObject.name)
        {

        } else if (other.collider.gameObject.name == turnPoint[4].gameObject.name)
        {
            OnTurn();
        } else if (other.collider.gameObject.name == turnPoint[5].gameObject.name)
        {
            OnTurn();
            print("DollTurn");
        } else if (other.collider.gameObject.name == turnPoint[6].gameObject.name)
        {
            UnTurn();
            transform.parent.rotation = Quaternion.Euler(0,180,0);
        } else if (other.collider.gameObject.name == turnPoint[7].gameObject.name)
        {
            OnTurn();
            print("ラストDush");
        } else if (other.collider.gameObject.name == isDollCollider.gameObject.name)
        {
            print("人形Start");
            Invoke("OnTurn", 4f);
            print("人形Turn");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.gameObject.name == turnPoint[0].gameObject.name)
        {
            UnTurn();
            transform.rotation = Quaternion.Euler(0,-10,0);
            Destroy(batParticle);
        }
        else if(other.collider.gameObject.name == turnPoint[1].gameObject.name)
        {
            UnTurn();
            transform.parent.rotation = Quaternion.Euler(0,-50,0);
        } else if (other.collider.gameObject.name == turnPoint[2].gameObject.name)
        {
            print("FrontDoor");
        } else if (other.collider.gameObject.name == turnPoint[3].gameObject.name)
        {
            UnTurn();
            transform.parent.rotation = Quaternion.Euler(0,0,0);

            print("WalkTrun");
        } else if (other.collider.gameObject.name == turnPoint[4].gameObject.name)
        {
            UnTurn();
            transform.parent.rotation = Quaternion.Euler(0,83,0);
            Destroy(turnPoint[4]);
        } else if (other.collider.gameObject.name == turnPoint[5].gameObject.name)
        {

        } else if (other.collider.gameObject.name == turnPoint[6].gameObject.name)
        {
            //UnTurn();
        }
    }

    void UnTurn()
    {
        turnOn.trackRotation = true;
        print("Gyaro");
    }

    void OnTurn()
    {
        turnOn.trackRotation = false;
        print("UnGyaro");
    }

}




