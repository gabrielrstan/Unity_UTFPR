using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManagar : MonoBehaviour
{

   

    public void returnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void restart()
    {
        SceneManager.LoadScene("Cena1");
    }
}
