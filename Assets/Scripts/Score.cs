using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreCount;
    TextMeshProUGUI textScore;
    
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textScore.text = "Score: "+scoreCount;
    }
}
