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

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
            if (gameCamera.orthographicSize - Input.mouseScrollDelta.y > 1)
                gameCamera.orthographicSize = gameCamera.orthographicSize - Input.mouseScrollDelta.y;
        if (Input.mouseScrollDelta.y < 0)
            if (gameCamera.orthographicSize - Input.mouseScrollDelta.y < 5)
                gameCamera.orthographicSize = gameCamera.orthographicSize - Input.mouseScrollDelta.y;
    }
}
