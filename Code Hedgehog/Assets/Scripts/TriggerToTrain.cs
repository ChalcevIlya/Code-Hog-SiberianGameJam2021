using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToTrain : MonoBehaviour
{
    public Animator Fade;

    void OnEnable()
    {
        Fade.SetTrigger("FadeOut");
    }
}
