using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawn : MonoBehaviour
{
    public GameObject awan;
    float spawnTime, timer;
    GameObject a;

    // Start is called before the first frame update
    void Start()
    {
        a = createAwan();
    }

    private GameObject createAwan()
    {
        GameObject temp = Instantiate(awan) as GameObject;
        temp.transform.position = transform.position;
        return temp;
    }

    // Update is called once per frame
    void Update()
    {
        if(a.GetComponent<movementCloud1>().hujan == true)
        {
            a = createAwan();

        }
    }
}
