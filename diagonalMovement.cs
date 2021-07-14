

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

​

public class diagonalMovement : MonoBehaviour

{

    float speed = 5f;

    bool change = true;

    private SpriteRenderer spriteRenderer;

    public float startPosition;

    // Start is called before the first frame update

    void Start()

    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        startPosition = GameObject.FindGameObjectWithTag("EnemyDiagonal").transform.position.x;

    }

​

    // Update is called once per frame

    void Update()

    {

        if (change)

        {

            moveObjectDiagDown();

        }

        if (!change)

        {

            moveObjectDiagUp();

        }

        if (GameObject.FindGameObjectWithTag("EnemyDiagonal").transform.position.x >= startPosition + 3f)

        {

            change = false;

            spriteRenderer.flipY = true;

        }

        if (GameObject.FindGameObjectWithTag("EnemyDiagonal").transform.position.x <= startPosition - 3f)

        {

            change = true;

            spriteRenderer.flipY = false;

        }

    }

    void moveObjectDiagDown()

    {

        transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);

    }

    void moveObjectDiagUp()

    {

        transform.Translate(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);

    }

}

​

