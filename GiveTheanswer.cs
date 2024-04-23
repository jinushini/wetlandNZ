using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GiveTheanswer : MonoBehaviour
{
    public GameObject ShowAnswer;
    void Start()
    {
        if (ShowAnswer != null)
        {
            ShowAnswer.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
{
     Invoke("ShowPanel", 2f);
}
    private void ShowPanel()
    {

     ShowAnswer.SetActive(true);
     Invoke("HideNewPanel", 15f);
        
    }
    private void HideNewPanel()
{

    if (ShowAnswer != null)
    {
        ShowAnswer.SetActive(false);
        Destroy(this);
        ScoreScript.scoreValue += 20;// 20 more score.
        }
}
}
