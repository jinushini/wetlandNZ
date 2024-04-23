using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAnimationTool : MonoBehaviour
{
    [SerializeField] Animator MouseAnimator;


    bool isRunning = false;// bool是一个方法，只有开始飞和停飞，只有在RobinHQ里面方格子才能是ture false,如果是圆格子就是个loop.
    public AudioClip song1;
    public AudioClip song2;

    private AudioSource audioSource;// Added an AudioSource component
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void Update()
    {
        MouseAnimator.SetBool("Run", isRunning);
    }

    public void startRunning()//设置开始飞和停飞的方法
    {
        isRunning = true;
        audioSource.PlayOneShot(song1, 1.5f); // Play the audio clip

    }

    public void stopRunning()
    {
        isRunning = false;
    }
    private void OnMouseDown()
    {
        askQuestion();
        audioSource.PlayOneShot(song2, 1f); // Play the audio clip
    }
    public void askQuestion()
    {
        MouseAnimator.Play("Spin");//
        //spawnSomething();

    }
    /*private void spawnSomething()//cube 
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position;
    }
    /*public void dissappearBird()
    {
        gameObject.SetActive(false);// disappear object
    }*/
}
