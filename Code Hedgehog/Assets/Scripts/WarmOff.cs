using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmOff : MonoBehaviour
{
    void OnEnable()
    {
        gameObject.SetActive(false);
    }
}
