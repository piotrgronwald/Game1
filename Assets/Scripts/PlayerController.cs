using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int blockValue = 2;
    
    int upgradesBlocks;

    Rigidbody rb;
    public float jumpForce;
    bool canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            SoundScript.JumpSound();
        }

    }

//gdy jest na ziemii moze skakac

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }   
    }

//gdy jest w powietrzu nie moze skakac

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Obstacle")
        {
            SoundScript.CrashSound();
            SceneManager.LoadScene("Game");
        }

        if(other.gameObject.tag == "UpgradeCube")
        {
            SoundScript.UpgradingSound();
            other.gameObject.SetActive(false);
            upgradesBlocks++;
        }
    }

}