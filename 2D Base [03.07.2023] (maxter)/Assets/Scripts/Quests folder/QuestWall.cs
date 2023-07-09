using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestWall : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" && other.GetComponent<Pickup>().id == 2)
        {
            Destroy(other.gameObject);
            anim.SetTrigger("isTriggered");
        }
    }
}
