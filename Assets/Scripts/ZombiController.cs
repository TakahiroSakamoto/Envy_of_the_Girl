using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.AI;


public class ZombiController : MonoBehaviour
{

    [SerializeField] private GameObject animationController;
    [SerializeField] private GameObject zombi;


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == animationController.name)
        {
            zombi.SetActive(true);
            //zombi.GetComponent<Animator>().SetBool("IsSttanding",true);
        }
    }
}
