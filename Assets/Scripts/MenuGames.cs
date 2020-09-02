using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGames : MonoBehaviour
{
    public int numGame;

    public void GoGame()
    {
        General.game = numGame;
        Debug.Log(General.game);
        SceneManager.LoadScene("GameScene");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
