using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class makefaceyaa : MonoBehaviour
{
    public SpriteRenderer uhm;
    public Sprite ss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plz == true)
        {
            Debug.Log("amk");
            makeface();

        }
    }
    public void makeface() {
        Debug.Log("makethafaca");
        uhm.sprite =ss;
        SceneManager.LoadScene(3);
        SlowerCoroutine();
        Force.speed = 0f;

    }
    public static IEnumerator FasterCoroutine()
    {
        Debug.Log("IE");
        plz = true;
        yield return new WaitForSeconds(0.2f);
        plz = false;
    }
    public bool may;
    public static bool plz;
    public IEnumerator SlowerCoroutine()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
    }
