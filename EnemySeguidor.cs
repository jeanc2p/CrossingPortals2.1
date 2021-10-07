using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySeguidor : MonoBehaviour
{

    GameObject player;
    NavMeshAgent enemy2;
    Animator anim2; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemy2 = this.GetComponent<NavMeshAgent>();
        anim2 = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy2.SetDestination(player.transform.position);
        if (enemy2.remainingDistance <= 4)
            anim2.SetBool("isMoving", false);
        else
            anim2.SetBool("isMoving", true);
        //&& anim3.SetBool("atach");

    }
}
