using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCloud1 : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;
    public Vector2 targetPosition;
    float speed = 0.25f;
    float sp, timer, cloudTimer;
    public float alphaLevel;
    SpriteRenderer sr;
    public bool cloudDestroy = false;
    public bool hujan = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(1, 1, 1, 0);
        timer = 0;
    }

    void Update()
    {
        // waktu awan sebelum bisa digerakan
        timer += Time.deltaTime;
        if (timer > 16.0f)
        {
            // Cara awan bergerak (menggunakan klik kiri mouse)
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                sp = speed;
                hujan = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * sp);
        }

        else
        {
            alphaLevel += (Time.deltaTime / 16);
            sr.color = new Color(1, 1, 1, alphaLevel);
        }

        if (hujan == true)
        {
            cloudTimer += Time.deltaTime;
            if (cloudTimer > 12.0f)
            {
                cloudDestroy = true;
                anim.SetBool("Hujan", true);
                if(cloudTimer > 16f)
                    Destroy(gameObject);
            }
        }
    }

}