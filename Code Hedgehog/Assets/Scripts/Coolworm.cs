using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coolworm : MonoBehaviour
{
    public Animator anim;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.transform.position.y > this.transform.position.y + 1.5)
        {
            anim.SetTrigger("FadeOut");
        }
    }
}
