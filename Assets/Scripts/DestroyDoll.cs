using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoll : MonoBehaviour {

    [SerializeField] private GameObject animCamera;
    [SerializeField] private GameObject doll;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animCamera.gameObject.name)
        {
            Destroy(doll);
            print("人形削除");
        }
    }
}
