using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalSpawn : MonoBehaviour
{

    public GameObject monkey;
    public GameObject cow;
    float spawnTime, timer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(40, 50);
        timer = spawnTime;
    }

    private void createAnimal()
    {
        int choice = Random.Range(0, 2);
        if (choice == 0)
        {
            GameObject a = Instantiate(monkey) as GameObject;
            a.transform.position = transform.position;
        }
        else
        {
            GameObject a = Instantiate(cow) as GameObject;
            a.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            createAnimal();
            timer = 0f;
            spawnTime = Random.Range(40, 50);
        }
    }
}
