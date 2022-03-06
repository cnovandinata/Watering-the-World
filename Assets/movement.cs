using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D Rb;
    public Vector2 targetPosition;
    public float speed;
    bool moveDone;


    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && moveDone == false)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveDone = true;
        }
 
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="BatasMap")
        {
            speed = 0;
        }
    }
}