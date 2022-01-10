using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    
    public Animator anim;
    public void HowToPlay()
    {
        anim.SetBool("WantsToOpen", true);
    }
    public void HowToPlayOff()
    {
        anim.SetBool("WantsToOpen", false);
    }
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(2);
    }

    public void ExitGame()
    {
        
        Application.Quit();
    }
    
}
