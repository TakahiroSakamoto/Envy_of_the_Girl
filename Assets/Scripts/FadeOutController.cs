using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutController : MonoBehaviour
{
    private GameObject[] vrCamera = new GameObject[2];
    [SerializeField] private GameObject firstCollider;
    [SerializeField] private Material fadeoutMaterial;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter(Collision other)
    {

       vrCamera[0] = GameObject.Find("AnimationCamera (1) Left");
        print(vrCamera[0].name);
       vrCamera[1] = GameObject.Find("AnimationCamera (1) Right");

        print(vrCamera[1].name);

        if (other.gameObject.gameObject.name == firstCollider.gameObject.name)
        {
            vrCamera[0].AddComponent<Fader>().m_Material = fadeoutMaterial;
            vrCamera[1].AddComponent<Fader>().m_Material = fadeoutMaterial;
            print("フェードアウトOK");
        }
        else
        {
            vrCamera[0].AddComponent<Fader>().m_Material = fadeoutMaterial;
            vrCamera[1].AddComponent<Fader>().m_Material = fadeoutMaterial;
            print("フェードアウトOK");
        }

    }
}
