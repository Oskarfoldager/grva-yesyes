using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnere : MonoBehaviour
{
    public GameObject playerr;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    // public float period = 20f;
    private float nextactiontime = 0;

    // Start is called before the first frame update
    void Update()
    {
        List<GameObject> enemys = new List<GameObject>() { enemy1, enemy2, enemy3 };
        if (Time.time > nextactiontime)
        {
            Random.InitState(System.DateTime.Now.Millisecond);
            int rand = Random.Range(0, 3);
            Debug.Log("Attempting to spawn enemy "+ transform.position + " " + rand);
            GameObject thisproj = Instantiate(enemys[rand], transform.position, transform.rotation);
            nextactiontime += Random.Range(3, 17);
        }


    }

   
}
