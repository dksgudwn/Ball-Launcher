using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }
    void DestroyBall()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("충돌");
        if(other.gameObject.tag == "Block" || other.gameObject.tag == "Floor")
        {
            Debug.Log("블록충돌");
            Invoke("DestroyBall",1f);
        }
    }
}
