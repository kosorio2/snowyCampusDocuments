

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

​

public class upDown : MonoBehaviour

{

    float speed = 5f;

    bool change = true;

    private SpriteRenderer spriteRenderer;

    public float startPosition;

    // Start is called before the first frame update

    void Start()

    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        startPosition = GameObject.FindGameObjectWithTag("EnemyUpDown").transform.position.y;

    }

​

    // Update is called once per frame

    void Update()

    {

        if (change)

        {

            moveObjectUp();

        }

        if (!change)

        {

            moveObjectDown();

        }

        if (GameObject.FindGameObjectWithTag("EnemyUpDown").transform.position.y >= startPosition + 3f)

        {

            change = false;

            spriteRenderer.flipY = true;

        }

        if (GameObject.FindGameObjectWithTag("EnemyUpDown").transform.position.y <= startPosition - 3f)

        {

            change = true;

            spriteRenderer.flipY = false;

        }

​

    

        }

        void moveObjectUp()

        {

            transform.Translate(0, speed * Time.deltaTime, 0);

        }

        void moveObjectDown()

        {

            transform.Translate(0, -speed * Time.deltaTime, 0);

        }

}

​


