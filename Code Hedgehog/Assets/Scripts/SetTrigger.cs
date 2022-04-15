using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetTrigger : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("TrainMoving");
    }
}
