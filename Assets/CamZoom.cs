using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    Camera gameCamera;

    // Start is called before the first frame update
    void Start()
    {
        gameCamera = GetComponent<Camera>();
    }


    void LateUpdate()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            if (gameCamera.orthographicSize - Input.mouseScrollDelta.y > 0.5f)
                gameCamera.orthographicSize = gameCamera.orthographicSize - Input.mouseScrollDelta.y;
            else
                gameCamera.orthographicSize = 0.5f;
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            if (gameCamera.orthographicSize - Input.mouseScrollDelta.y < 5)
                gameCamera.orthographicSize = gameCamera.orthographicSize - Input.mouseScrollDelta.y;
            else
                gameCamera.orthographicSize = 5f;
        }

    }
}
