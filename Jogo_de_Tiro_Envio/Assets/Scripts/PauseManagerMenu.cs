using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManagerMenu : MonoBehaviour
{
    public void returnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void restart()
    {
        SceneManager.LoadScene("Cena1");
    }

    public void pauseMenu()
    {
        SceneManager.LoadScene("PauseMenu");

    }

}
