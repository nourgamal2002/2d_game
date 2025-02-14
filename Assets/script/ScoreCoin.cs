using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCoin : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;




    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score : " + ScoreNum;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="MyCoin")
        {
            ScoreNum += 1;

            MyScoreText.text = "Score : " + ScoreNum;

            Destroy(other.gameObject);
           
        }
    }



}



