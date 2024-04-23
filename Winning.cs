using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject Trophy;
    // Start is called before the first frame update
    void Start()
    {
        Trophy.SetActive(false);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        Trophy.SetActive(true);
        Invoke("HideNewPanel", 2f);//10 seconds to do hide panel
    }
    private void HideNewPanel()
    {
        // Hide 

        if (Trophy != null)
        {
            Trophy.SetActive(false);
        }
    }

}
