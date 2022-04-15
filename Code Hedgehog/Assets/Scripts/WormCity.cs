using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormCity : MonoBehaviour
{
    public Animator anim, city;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Mathf.Abs(collision.transform.position.y - this.transform.position.y) > 1.5)
        {
            anim.SetTrigger("Dead");
            if (gameObject.tag == "W1") city.SetTrigger("1");
            else if (gameObject.tag == "W2") city.SetTrigger("2");
            else if (gameObject.tag == "W3") city.SetTrigger("3");
            else if (gameObject.tag == "W4") city.SetTrigger("4");
            else if (gameObject.tag == "W5") city.SetTrigger("5");
        }
    }
}
