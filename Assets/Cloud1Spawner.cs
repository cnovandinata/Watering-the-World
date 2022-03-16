using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1Spawner : MonoBehaviour
{
    public GameObject cloud;
    movementCloud1 start;
    float time = 0;
    float timer = 16;

    // Start is called before the first frame update
    void Start()
    {
        start = cloud.GetComponent<movementCloud1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time<=0 && start.cloudDestroy == true)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
            time = timer;
        } 
        else
        {
            time -= Time.deltaTime;
        }
    }
}
