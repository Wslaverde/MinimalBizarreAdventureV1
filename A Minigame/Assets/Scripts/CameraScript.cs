using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Glitch;

    void Update()
    {
        if (Glitch != null)
        {
            Vector3 position = transform.position;
            position.x = Glitch.transform.position.x;
            transform.position = position;
        }

    }
}
