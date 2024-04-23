using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitAnimationTool : MonoBehaviour
{
    [SerializeField] Animator rabbitAnimator;//为了让animator可视化在unity右侧，需要把animator拖进去
    [SerializeField] Animator rabbitAnimatorPath;//让我们在rabbit animation tool 这个脚本下可以看到控制器


    /* [SerializeField] CapsuleCollider spawn;*/
    // Start is called before the first frame update
    bool isRunning = false;
    public AudioClip song1;
    public AudioClip song2;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }


    // Update is called once per frame
    void Update()
    {
        rabbitAnimator.SetBool("Run", isRunning);
        /*if (Input.GetKeydown(Keycode.space))
    {   
      GetComponent<Animator>().play("dead");
        }*/
    }

    public void askQuestion()
    {
        rabbitAnimator.Play("Jump");//
        rabbitAnimatorPath.enabled = false;
        //spawnSomething();

    }

    /*private void spawnSomething()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position;
    }*/

    private void OnMouseDown()
    {
        askQuestion();
        audioSource.PlayOneShot(song2, 1f);
    }

    public void startRunning()
    {
        isRunning = true;
        audioSource.PlayOneShot(song1, 1.5f);
    }
    public void stopRunning()
    {
        isRunning = false;
    }
}
