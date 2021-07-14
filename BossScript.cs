

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

​

public class BossScript : MonoBehaviour

{

    public int health = 100;

​

    private void OnTriggerEnter2D(Collider2D collision)

    {

        ProcessCollision(collision.gameObject);

    }

​

    private void OnCollisionEnter2D(Collision2D collison)

    {

        ProcessCollision(collison.gameObject);

    }

​

    void ProcessCollision(GameObject collider)

    {

        if (collider.CompareTag("Player"))

        {

            DoDamageToPlayer();

            Debug.Log(health);

            Debug.Log("IN the COLLISION");

            if (health <= 50)

            {

                this.gameObject.transform.localScale -= new Vector3(1 / 2, 1 / 2, 1 / 2);

            }

            if (health <= 0)

            {

                this.gameObject.transform.localScale -= new Vector3(0, 0, 0);

            }

        }

    }

​

    void DoDamageToPlayer()

    {

        health -= 25;

​

    }

​

}

