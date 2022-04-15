using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToLoading : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Loading1");
    }
}
