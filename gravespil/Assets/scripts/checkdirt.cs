using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkdirt : MonoBehaviour
{
    
    public int grasslevel = 30;
    public List<GameObject> Ys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool AllIsAbove = true;
        foreach (var y in Ys)
        {
            if (y.transform.position.y<grasslevel)
            {
                AllIsAbove = false;
            }
        }
        if (AllIsAbove)
        {
            Debug.Log("all dirt is above grass level");
            SceneManager.LoadScene(4);
        }
    }
}
