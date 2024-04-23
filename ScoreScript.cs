using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public static int scoreValue = 0;

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Score:" + scoreValue + "/40";
    }
}
