using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public AudioClip ac1, ac2;
    public AudioSource AS;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if ((SceneManager.GetActiveScene().name == "Cutscene2" && AS.clip == ac1) || (SceneManager.GetActiveScene().name == "Bar" && AS.clip == ac2))
        {
            gameObject.SetActive(false);
        }
    }
}
