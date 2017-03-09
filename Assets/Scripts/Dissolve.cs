using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Renderer _renderer;
    private float time;


	// Use this for initialization
	void Start ()
	{
	    _renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{



	        Invoke("DissolveTitle", 2.0f);



	}

    void DissolveTitle()
    {
        time += Time.deltaTime * 0.7f;
        _renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化を忘れずに
        _renderer.material.SetFloat("_Cutoff", time);
    }

    void StartDissolve()
    {
        time += -Time.deltaTime * 0.7f;
        _renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化を忘れずに
        _renderer.material.SetFloat("_Cutoff", time);
    }
}


