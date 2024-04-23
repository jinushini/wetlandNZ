using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public void PlayGame1()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayMenu()
    {
        SceneManager.LoadScene(0);
        ScoreScript.scoreValue = 0;//set score to zero every times quit the scene
    }
    public void QuitWindow1()
    {
        Answer1.SetActive(false);
    }
    public void QuitWindow2()
    {
        Answer2.SetActive(false);
    }
    public void QuitWindow3()
    {
        Answer3.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
