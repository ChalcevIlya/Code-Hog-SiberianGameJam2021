using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToCity : MonoBehaviour
{
    public Animator Fade;

    void OnEnable()
    {
        Fade.SetTrigger("FadeOut");
    }
}
