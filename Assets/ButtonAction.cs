using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CloudPick()
    {
        SceneManager.LoadScene(2);
    }

    public void stage1()
    {
        SceneManager.LoadScene(3);
    }
}
