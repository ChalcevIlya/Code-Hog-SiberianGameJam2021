using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    [SerializeField] private string nextScene = "";

    [SerializeField] private bool disableFadeInAnimation = false;

    public GameObject UI;

    private void Start()
    {
        if (disableFadeInAnimation)
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.Play("FadeIn", 0, 1);
        }
    }

    void FadeOutFinished()
    {
        SceneManager.LoadScene(nextScene);
    }
}
