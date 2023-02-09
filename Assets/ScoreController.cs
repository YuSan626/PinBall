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

        SetScore();  //�����X�R�A���


    }

    // �傫���_7�_�A�������_5�_�A�傫����3�_�A��������1�_
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



