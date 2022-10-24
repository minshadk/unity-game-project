using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    private int score=0;
    public Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.gameObject.CompareTag("Collectible"))
        {

            score++;
            Debug.Log(score);
            scoreText.text = "Score " + score; 
            
            Destroy(collision.gameObject);
        }
    }
}
