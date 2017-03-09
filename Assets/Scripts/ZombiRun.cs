using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiRun : MonoBehaviour {
    [SerializeField] private GameObject animationController;
    NavMeshAgent agent = new NavMeshAgent();
    private Animator zombiAnimator;
    [SerializeField] private GameObject zombi;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animationController.name)
        {
            Invoke("BornZombi", 1.5f);
        }
    }

    void BornZombi()
    {
        zombi.SetActive(true);
        //zombiAnimator.enabled = true;
        agent = zombi.GetComponent<NavMeshAgent> ();
        agent.speed = 4;
        //zombiAnimator = GetComponent<Animator>();
        //zombiAnimator.SetBool("IsWalk",true);
        agent.SetDestination(animationController.transform.position);
        Destroy(zombi,2f);
    }

    void DestroyZombi()
    {

    }

//    void ShautZomib()
//    {
//
//    }
}
