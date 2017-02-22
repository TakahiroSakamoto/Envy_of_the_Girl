using System.Collections;
using System.Collections.Generic;
//using UnityEditor.iOS.Xcode;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    //[SerializeField] private GameObject animationCamera;
    private GvrHead turnOn;

    [SerializeField] private GameObject[] turnPoint;


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
        print("Enter");
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
            UnTurn();
        } else if (other.collider.gameObject.name == turnPoint[4].gameObject.name)
        {
            OnTurn();
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.gameObject.name == turnPoint[0].gameObject.name)
        {
            UnTurn();
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else if(other.collider.gameObject.name == turnPoint[1].gameObject.name)
        {
            UnTurn();

        } else if (other.collider.gameObject.name == turnPoint[2].gameObject.name)
        {
            print("FrontDoor");
        } else if (other.collider.gameObject.name == turnPoint[3].gameObject.name)
        {
            UnTurn();
            transform.rotation = Quaternion.Euler(0,180,0);
            print("WalkTrun");
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




