using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepoint : MonoBehaviour
{
    public int maxY;
    public int minY;
    public int maxX;
    public int minX;

    public int minROT;
    public int maxROT;

    public GameObject pointtomove;

    public float movespeed;
    public float rotatespeed;

    public void Update()
    {
        float z = pointtomove.transform.rotation.eulerAngles.z;
        if (Input.GetKey(KeyCode.S) && pointtomove.transform.position.y > minY)
        {
            pointtomove.transform.position = new Vector3(pointtomove.transform.position.x, pointtomove.transform.position.y - movespeed, pointtomove.transform.position.z);
        }
        if (Input.GetKey(KeyCode.A) && pointtomove.transform.position.x > minX)
        {
            pointtomove.transform.position = new Vector3(pointtomove.transform.position.x - movespeed, pointtomove.transform.position.y, pointtomove.transform.position.z);
        }
        if (Input.GetKey(KeyCode.W) && pointtomove.transform.position.y < maxY)
        {
            pointtomove.transform.position = new Vector3(pointtomove.transform.position.x, pointtomove.transform.position.y + movespeed, pointtomove.transform.position.z);
        }
        if (Input.GetKey(KeyCode.D) && pointtomove.transform.position.x < maxX)
        {
            pointtomove.transform.position = new Vector3(pointtomove.transform.position.x + movespeed, pointtomove.transform.position.y, pointtomove.transform.position.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            z = z + rotatespeed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //pointtomove.transform.eulerAngles = new Vector3(pointtomove.transform.rotation.eulerAngles.x, pointtomove.transform.rotation.eulerAngles.y, pointtomove.transform.rotation.eulerAngles.z - rotatespeed);
            z = z - rotatespeed;
            
        }

        z = (z + 360) % 360;

        if (z > maxROT && z <= maxROT + 50)
        {
                z = maxROT;
            
        }
        if (z < 360 + minROT && z > 360 + minROT - 50)
        {
            z = 360 + minROT;
        }

        //float newZ = Mathf.Max(Mathf.Min(pointtomove.transform.rotation.eulerAngles.z, maxROT), minROT);
        Debug.Log("" + minROT + " " + maxROT + " " + pointtomove.transform.rotation.eulerAngles.z + " " + z);
        
        // && pointtomove.transform.rotation.eulerAngles.z >= minROT && pointtomove.transform.rotation.eulerAngles.z <= maxROT
        pointtomove.transform.eulerAngles = new Vector3(pointtomove.transform.rotation.eulerAngles.x, pointtomove.transform.rotation.eulerAngles.y, z);

    }
}
