using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToMenu : MonoBehaviour
{
    public Animator Fade;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Fade.SetTrigger("FadeOut");
    }
}
