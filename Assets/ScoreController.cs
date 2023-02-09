using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject ScoreText;
    private int score = 0;
    private GameObject Score;


    // Start is called before the first frame update
    void Start()
    {

        this.ScoreText = GameObject.Find("ScoreText");

        SetScore();  //初期スコア代入


    }

    // 大きい雲7点、小さい雲5点、大きい星3点、小さい星1点
    void OnCollisionEnter(Collision collision)

    {
        string Tag = collision.gameObject.tag;

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 7;
        }

        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
        }

        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 3;
        }

        else if (collision.gameObject.tag == "SmallStarTag") 
        {
            score += 1;
        }
        SetScore();
    }

    void SetScore()
    {
        this.ScoreText.GetComponent<Text>().text = "Score" + score;

    }
}



