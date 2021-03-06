﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public Text winText;
    private int count;
    public AudioSource[] sounds;
    //public AudioSource noise1;
    //public AudioSource noise2;
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
        count = 0;
        winText.text = "";        
    }	

    void FixedUpdate()
    {

         //Vector3 m_Movement = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
         //transform.Translate(m_Movement * 10 * Time.deltaTime);

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
            rb.AddForce(movement * speed);

        }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {

            PlaySounds(0);
            other.gameObject.SetActive(false);
            count = count + 1;
            
           // string str = "YOU WIN..!";
            if(count>=14)
            {
                GameObject go = GameObject.Find("Path1Right (2)");
                go.SetActive(false);
                PlaySounds(1);
               // openDoor("Path1Right (2)");

                winText.text = "YOU WIN...!";
               // SceneManager.LoadScene("Scene2");

            }
        }
    }
    void openDoor()
    {
        //DeactivatePath.Destroy()
       
    }
    void PlaySounds(int index)
    {
        sounds = GetComponents<AudioSource>();
        sounds[index].Play();
       
    }

    void setCount()
    {
        count = count + 1;

    }
	
}
