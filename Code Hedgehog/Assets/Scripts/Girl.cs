using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public bool first = true, firstoff = false, inGirl = false, collected = false;
    public GameObject Window, Text1;
    public Animator Fade;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inGirl)
        {
            if (first)
            {
                FirstTalk();
            }
            else if (firstoff)
            {
                FirstTalkOff();
            }
            else if (collected)
            {
                Fade.SetTrigger("FadeOut");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        inGirl = true;
        if (collider.gameObject.GetComponent<Platformer>().countcollect == 8)
        {
            collected = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        inGirl = false;
    }

    void FirstTalk()
    {
        Text1.SetActive(true);
        Window.SetActive(true);
        first = false;
        firstoff = true;
    }

    void FirstTalkOff()
    {
        Text1.SetActive(false);
        Window.SetActive(false);
        firstoff = false;
    }
}
