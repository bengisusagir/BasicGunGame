using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossair : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Vector2 crosshairPosition = Input.mousePosition;

        transform.position = crosshairPosition;
    }
}
