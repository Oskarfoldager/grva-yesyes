using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    public static int enemysonscreen;
    public GameObject tegn;
    // Start is called before the first frame update
    void Start()
    {

        
        tegn = GameObject.Find("tegner");
        Image tegney = tegn.GetComponent<Image>();
        tegney.color = new Color(1f, 1f, 1f, 0f);
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
        else if (col1.gameObject.tag == "tegn")
        {
            Debug.Log("tegning");
            tegnNU();
        }
    }
    void tegnNU()
    {

        StartCoroutine(FasterCoroutine());
    }


IEnumerator FasterCoroutine()
{
        Image tegney = tegn.GetComponent<Image>();
        tegney.color = new Color(255f, 0f, 0f, 1f);
        yield return new WaitForSeconds(2);
        tegney.color = new Color(1f, 1f, 1f, 0f);

    }

    }
