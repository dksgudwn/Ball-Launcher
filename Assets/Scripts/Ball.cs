using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Score score;
    void Start()
    {
        score = GetComponent<Score>();
    }

    void Update()
    {
        
    }
    void DestroyBall()
    {
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Block" || other.gameObject.tag == "Floor")
        {
            Invoke("DestroyBall",1f);
        }
        if(other.gameObject.tag == "Target")
        {
            Destroy(other.gameObject);
            //score.scoreCount++;
        }
    }
}
