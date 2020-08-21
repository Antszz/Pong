using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDead : MonoBehaviour
{
    public ChangeScene changeScene;
    public Text textScore;
    int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        score++;
        textScore.text = score.ToString();
        checkScore(collision);
    }
    void checkScore(Collider2D collision)
    {
        if (score == 3)
        {
            if (textScore.CompareTag("textEnemy"))
            {
                changeScene.changeScene("LoseScene");
            }
            else
            {
                changeScene.changeScene("WinScene");
            }
        }
        else
        {
            collision.GetComponent<BallBehavior>().start = false;
        }
    }
}
