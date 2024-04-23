using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMeshProTypewriter : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string fullText;
    public float typingSpeed = 0.1f;

    private string currentText = "";
    private int index = 0;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        fullText = textMeshPro.text; // Get the full text from the TextMeshPro component
        textMeshPro.text = ""; // Clear the text initially
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        while (index < fullText.Length)
        {
            currentText += fullText[index];
            textMeshPro.text = currentText;
            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
