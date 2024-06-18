using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiGenerator : MonoBehaviour
{
    bool isEnter = false;
    public GameObject sushi;
    public GameObject look;
    AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEnter = true;
            look.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        isEnter = false;


    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnter && Input.GetKey(KeyCode.E))
        {
            sushi.SetActive(true);
            GetComponent<AudioSource>().Play();
            look.SetActive(false);
        }


    }

}