
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiAnimationTool : MonoBehaviour
{
    [SerializeField] Animator kiwiAnimator;//为了让animator可视化在unity右侧，需要把animator拖进去
    [SerializeField] Animator kiwiAnimatorPath;//让我们在rabbit animation tool 这个脚本下可以看到控制器
    /* [SerializeField] CapsuleCollider spawn;*/
    // Start is called before the first frame update
    bool isRolling = false; 
    bool isWalking = false;
    public GameObject Trophy;
    public AudioClip song1;
    public AudioClip song2;
    private AudioSource audioSource;// Added an AudioSource component
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }
    void Awake()
    {
        Debug.Log("Setting trophy to innactive");
        Trophy.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        kiwiAnimator.SetBool("Roll", isRolling);
        kiwiAnimator.SetBool("Walk", isWalking);
        /*if (Input.GetKeydown(Keycode.space))
    {   
      GetComponent<Animator>().play("dead");
        }*/
    }

    public void askQuestion()
    {
        kiwiAnimator.Play("Jump");//
        kiwiAnimatorPath.enabled = false;
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
        Trophy.SetActive(true);
        audioSource.PlayOneShot(song2, 0.8f);
        Invoke("HidePanel", 10f);//10 seconds to do hide panel

    }

    public void startRolling()
    {
        isRolling = true;
        audioSource.PlayOneShot(song1, 0.5f);
    }
    public void stopRolling()
    {
        isRolling = false;
    }
    public void startWalking()
    {
        isWalking = true;
    }
    public void stopWalking()
    {
        isWalking = false;
    }
    private void HidePanel()
    {
        // Hide 

        if (Trophy != null)
        {
            Trophy.SetActive(false);
        }
    }
}
