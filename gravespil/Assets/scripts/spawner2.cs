using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    public GameObject playerr;
    public GameObject enemy1;

    // public float period = 20f;
    private float nextactiontime = 0;

    // Start is called before the first frame update
    void Update()
    {
        List<GameObject> enemys = new List<GameObject>() { enemy1, };
        if (Time.time > nextactiontime)
        {
            Debug.Log("Attempting to spawn enemy");
            GameObject thisproj = Instantiate(enemys[Random.Range(0, 3)], transform.position, transform.rotation);
            nextactiontime += Random.Range(3, 16);
        }


    }


}
