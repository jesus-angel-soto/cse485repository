using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyaction : MonoBehaviour
{
    public breadaction bread;
    private Rigidbody erb;
    public float speed = -0.1f;
    private Animator enemyanimation;
    private bool check = false;
    void Start()
    {
        erb = GetComponent<Rigidbody>();
        enemyanimation = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        //float x = Time.time * speed;
        transform.localScale = new Vector3(-8.113075f, 8.113075f, 8.113075f);
        erb.velocity = new Vector3(-speed, erb.velocity.y, 0);
        if (check)
        {
            transform.localScale = new Vector3(8.113075f, 8.113075f, 8.113075f);
            erb.velocity = new Vector3(speed, erb.velocity.y, 0);
        }
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
        if (other.tag == "break") 
        {
            bread.go.SetActive(false);
            bread.speed = 0f;
            enemyanimation.SetBool("eat", true);
            speed = 0f;
        }
    }
}
