using UnityEngine;
using System.Collections;

public class Force : MonoBehaviour
{
    // Movement speed
    public float speed = 2;
    private float timeofnewspeed;

    // Use this for initialization
    void Start()
    {
        timeofnewspeed = Time.time + 18;
        // Fly towards the right
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeofnewspeed)
        {
            Debug.Log("newspeed");
            Destroy(this.gameObject);
            timeofnewspeed += 18;
        }
        /*moving the eraser*/
        transform.position = new Vector3(transform.position.x + speed, transform.position.z);
    }
}