

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

​

public class leftRight : MonoBehaviour

{

​

    float speed = 5f;

    bool change = true;

    private SpriteRenderer spriteRenderer;

    public float startPosition;

    // Start is called before the first frame update

    void Start()

    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        startPosition = GameObject.FindGameObjectWithTag("EnemyLeftRight").transform.position.x;

    }

​

    // Update is called once per frame

    void Update()

    {

        if (change)

        {

            moveObjectRight();

        }

        if (!change)

        {

            moveObjectLeft();

        }

        if (GameObject.FindGameObjectWithTag("EnemyLeftRight").transform.position.x >= startPosition + 3f)

        {

            change = false;

            spriteRenderer.flipX = true;

        }

        if (GameObject.FindGameObjectWithTag("EnemyLeftRight").transform.position.x <= startPosition - 3f)

        {

            change = true;

            spriteRenderer.flipX = false;

        }

    }

    void moveObjectRight()

    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

    void moveObjectLeft()

    {

        transform.Translate(-speed * Time.deltaTime, 0, 0);

    }

}

