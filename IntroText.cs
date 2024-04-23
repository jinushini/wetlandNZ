using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroText : MonoBehaviour
{
    public void PlayNext()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayNext2()
    {
        SceneManager.LoadScene(1);
    }
}
