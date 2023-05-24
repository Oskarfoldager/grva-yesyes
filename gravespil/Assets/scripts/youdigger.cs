using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youdigger : MonoBehaviour
{
    

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "dirt")
        {
            Debug.Log("hit");
            if (trigger.enemysonscreen > 0)
            {
                Debug.Log("jim");
                StartCoroutine(makefaceyaa.FasterCoroutine());
            }

        }
    }

}


