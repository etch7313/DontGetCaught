using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public Animator anim;
    public GameObject hunterWinsTxt;
    public GameObject preyWinsTxt;
    public float gameTime =120;
    public TextMeshProUGUI timetxt;
    public GameObject timeObject;
    public GameObject playerOne;
    public GameObject playerTwo;
    int hunterScore=0;
    int preyScore=0;
    public TextMeshProUGUI score;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckGameTime();
    }

    void CheckGameTime()
    {
        if (gameTime <= 0.1f)
        {
            preyScore++;
            anim.SetBool("ScoreOn", true);
            preyWinsTxt.SetActive(true);
            hunterWinsTxt.SetActive(false);
            playerOne.SetActive(false);
            playerTwo.SetActive(false);
            score.SetText(hunterScore + " - " + preyScore);
            
        }
        else
        {
            gameTime=gameTime-Time.deltaTime;
            int x = (int)gameTime;
            timetxt.SetText(x.ToString());
            

            
        }
    }

    public void RetryGame()
    {
        playerOne.SetActive(true);
        playerTwo.SetActive(true);
        timeObject.SetActive(true);
        gameTime = 120;
        anim.SetBool("ScoreOn", false);
        playerOne.transform.position = new Vector3(0.2f, -43.9f, 90);
        playerTwo.transform.position = new Vector3(-0.2f, 42.42f, 90);
        playerOne.transform.localEulerAngles = Vector3.zero;
        StartCoroutine(TextAfterAnimaTion());

    }

    IEnumerator TextAfterAnimaTion()
    {
        yield return new WaitForSeconds(0.55f);
        preyWinsTxt.SetActive(false);
        hunterWinsTxt.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag=="Prey")
        {
            hunterScore++;
            score.SetText(hunterScore + " - " + preyScore);
            timeObject.SetActive(false);
            playerOne.SetActive(false);
            playerTwo.SetActive(false);
            hunterWinsTxt.SetActive(true);
            preyWinsTxt.SetActive(false);
            anim.SetBool("ScoreOn", true);
        }
    }

    
}
