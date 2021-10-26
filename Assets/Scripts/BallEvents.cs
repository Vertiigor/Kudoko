using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallEvents : MonoBehaviour
{
    [SerializeField] Text scoreText;
    static public int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bonus")
        {
            score++;
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            score -= 2;
        }
        Destroy(collision.gameObject);
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

}
