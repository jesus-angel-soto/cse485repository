using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyaction : MonoBehaviour
{
    private Rigidbody erb;
    private float speed = 5f;
    private Animator enemyanimation;
    private bool check = false;
    void Start()
    {
        erb = GetComponent<Rigidbody>();
        enemyanimation = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(check)
        erb.velocity = new Vector3(speed, erb.velocity.y, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
       {
            other.GetComponent<health>().hp -= 1;
            Debug.Log("HP--");
            enemyanimation.SetBool("hit",true);
            check = true;
        }
    }
}
