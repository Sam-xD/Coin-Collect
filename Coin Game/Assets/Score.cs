using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;
    public void counter()
    {
        score = score + 1;
    }
    
    public Text sc;
    
    void Update()
    {

        sc.text = "Coins:"+score.ToString();
    }
}
