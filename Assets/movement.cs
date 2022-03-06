using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D Rb;
    public Vector2 targetPosition;
    public float speed;
    float sp;
    float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 8.0f)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                sp = speed;
            }
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * sp);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="BatasMap")
        {
            sp = 0;
        }
    }
}