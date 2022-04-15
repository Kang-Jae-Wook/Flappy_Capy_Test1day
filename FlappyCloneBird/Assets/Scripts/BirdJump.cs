using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;

    public float JumpPower;
    int num;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * JumpPower;
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
