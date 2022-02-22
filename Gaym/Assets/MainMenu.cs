using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void ExitGame()
    {
        Debug.Log("Игра закрылась, а ты хуле думал?"); //не забыть убрать эту хуйню от греха подальше когда будем билд собирать, хотя можно по рофлу и оставить, ничего плохого не будет
        Application.Quit();
    } 

}
