using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winloseScript : MonoBehaviour
{
    public int animalNum;
    // Start is called before the first frame update
    void Start()
    {
        animalNum = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(animalNum <= 0)
        {
            SceneManager.LoadScene(7);
        }
        
        if(animalNum >= 10)
        {
            SceneManager.LoadScene(6);
        }
    }
}
