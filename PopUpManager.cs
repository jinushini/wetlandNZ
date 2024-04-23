using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PopUpManager : MonoBehaviour
{

    public GameObject ConfirmationWindow; // Reference to the ConfirmationWindow canvas panel
    public Button yesButton;
    public Button noButton;
    public TextMeshProUGUI questionContent;
    public GameObject YesPanel;
    public GameObject NoPanel;
    public GameObject CorrectAnswer;


    void Start()
    {
        // Make sure the confirmationWindow is initially hidden
        if (ConfirmationWindow != null)
        {
            ConfirmationWindow.SetActive(false);
        }
        if (YesPanel != null)
        {
            YesPanel.SetActive(false);
        }
        if (NoPanel != null)
        {
            NoPanel.SetActive(false);
        }
        if (CorrectAnswer != null)
        {
            CorrectAnswer.SetActive(false);
        }
        if (yesButton != null)
        {
            yesButton.onClick.AddListener(YesClicked);
        }

        if (noButton != null)
        {
            noButton.onClick.AddListener(NoClicked);
        }
    }
    private void OnMouseDown()
    {
        ConfirmationWindow.SetActive(true);
    }
    private void YesClicked()
    {
        if (gameObject.activeSelf)
        {
            // Implement what should happen when 'Yes' is clicked
            Debug.Log("Yes button clicked.");
            ConfirmationWindow.SetActive(false);
            YesPanel.SetActive(true);
            //AnimalController.newAnimalGo();
            //questionContent.text = "Yes was clicked. What would you like to do next?";
            Invoke("ShowAnser", 3f);
        }
    }

    private void NoClicked()
    {
        if (gameObject.activeSelf)
        {
            // Implement what should happen when 'No' is clicked
            Debug.Log("No button clicked.");
            ConfirmationWindow.SetActive(false);
            NoPanel.SetActive(true);
            Invoke("ShowAnser", 3f);
        }

    }
    private void ShowAnser()
    {
        NoPanel.SetActive(false);
        YesPanel.SetActive(false);
        CorrectAnswer.SetActive(true);
        Invoke("HideNewPanel", 10f);//5 seconds to do hide panel
    }
    private void HideNewPanel()
    {
        // Hide 

        if (CorrectAnswer != null)
        {
            CorrectAnswer.SetActive(false);
            gameObject.SetActive(false);
            AnimalController.newAnimalGo();
            ScoreScript.scoreValue += 10;//every times 10 more score.
            Destroy(this);
        }
    }
}