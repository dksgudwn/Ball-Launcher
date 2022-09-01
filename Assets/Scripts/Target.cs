using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12, 12), Mathf.Clamp(transform.position.y, -3.5f, 7));
    }
}
