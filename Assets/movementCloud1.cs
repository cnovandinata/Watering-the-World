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
    bool cek;
    public bool respawn;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
                anim.SetBool("Move", true);
                respawn = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * sp);
        }
    }

    // Control awan tidak bisa keluar dari map
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BatasMap")
        {
            sp = 0;
        }
    }
}