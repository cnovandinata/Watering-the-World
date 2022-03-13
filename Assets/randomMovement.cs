using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 targetPosition;
    float sp = 0.25f;
    float timer, movementTime;
    public Animator animator;
    bool flipped = false;
    Vector3 newScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targetPosition = new Vector2(transform.position.x, transform.position.y);
        movementTime = Random.Range(10, 20);
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Mengatur pergerakan 
        timer += Time.deltaTime;
        if(timer >= movementTime)
        {
            targetPosition = new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f));
            timer = 0f;
            movementTime = Random.Range(10, 20);
            sp = 0.25f;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * sp);

        //Mengatur Animasi
        if (transform.position.x == targetPosition.x && transform.position.y == targetPosition.y)
            animator.SetBool("Move", false);
        else
            animator.SetBool("Move", true);

        //Mengatur arah sprite
        if (flipped)
        {
            if (targetPosition.x > transform.position.x)
            {
                newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
                flipped = false;
            }
        }
        else
        {
            if (targetPosition.x < transform.position.x)
            {
                newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
                flipped = true;
            }
        }
    }
}
