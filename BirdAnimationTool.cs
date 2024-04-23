using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimationTool : MonoBehaviour
{
    [SerializeField] Animator birdAnimator;


    bool isFlying = false;// bool是一个方法，只有开始飞和停飞，只有在RobinHQ里面方格子才能是ture false,如果是圆格子就是个loop.
    public AudioClip song1;
    public AudioClip song2;
    public AudioClip flyAway1;
    //public AudioClip flyAway2;
    private AudioSource aSource;// Added an AudioSource component
    void Start()
    {
        aSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void Update()
    {
        birdAnimator.SetBool("flying", isFlying); 
    }

    public void startFlying()//设置开始飞和停飞的方法
    {
        isFlying = true;
        aSource.clip = flyAway1; // Play the audio clip
        aSource.Play();

    }

    /*public void stopAudio()//写个脚本暂停声音加入到动画里
    {
        aSource.Stop();
    }
    */
    public void stopFlying()
    {
        isFlying = false;
        aSource.loop = false;
        aSource.clip = song1;
        aSource.volume = 1;
        aSource.Play();
    }
    private void OnMouseDown()
    {
        askQuestion();
        aSource.clip = song2; // Play the audio clip
        aSource.Play();
    }
    public void askQuestion()
    {
        birdAnimator.Play("Spin");
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
