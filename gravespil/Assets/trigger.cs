using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public int enemysonscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("enemysonscreen " + enemysonscreen);
    }
    void OnTriggerEnter2D(Collider2D col1)
    {
        Debug.Log("OnCollisionEnter2D");

        if (col1.gameObject.tag == "1+")
        {
            Debug.Log("+1");
            enemysonscreen++;

        }else if (col1.gameObject.tag == "-1")
        {
            Debug.Log("-1");
            enemysonscreen--;
        }
    }
}
