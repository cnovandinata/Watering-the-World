using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCloud1 : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 targetPosition;
    float speed = 0.25f;
    float sp, timer, cloudTimer;
    bool cloudDestroy;

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
                cloudDestroy = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * sp);
        }

        // Jika kapasistas awan habis, awan akan hancur
        if (cloudDestroy == true)
        {
            cloudTimer += Time.deltaTime;
            if (cloudTimer > 16.0f)
            {
                Destroy(gameObject);
            }
        }
    }

    // Jika awan menyentuh pinggir map, dia akan berhenti
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BatasMap")
        {
            sp = 0;
        }
    }
}