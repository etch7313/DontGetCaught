using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColDet : MonoBehaviour
{
    public GameObject playerOne;
    public void WakePlayer1()
    {
        playerOne.SetActive(true);
    }

    public void ExitGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
