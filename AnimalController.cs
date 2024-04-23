using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public static AnimalController instance;

    public GameObject animal1;
    public GameObject animal2;
    public GameObject animal3;

    static int animalReference = 1;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

        animalReference = 1;
        animal1.SetActive(true);// one animal always there 
        animal2.SetActive(false);
        animal3.SetActive(false);
    }
    public static void newAnimalGo()
    {
        instance.Invoke("ActivateAnimal1AfterDelay", 20f);
        animalReference++;
    }
    private void ActivateAnimal1AfterDelay()
    {
         if (animalReference == 2)
        {
            instance.animal2.SetActive(true);
        }
        else if (animalReference == 3)
        {
            instance.animal3.SetActive(true);
        }
    }
}
