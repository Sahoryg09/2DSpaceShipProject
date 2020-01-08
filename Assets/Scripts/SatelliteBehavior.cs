using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteBehavior : MonoBehaviour
{
    public float speed;
    public float bottomBounds;
    public float topBounds;
    public float xBounds;


    private Vector3 move = new Vector3(0f, 1f, 0f);


    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime * speed;

        if (transform.position.y > bottomBounds)
        {
            transform.position = new Vector3(Random.Range(xBounds, -xBounds),topBounds, 0f);
        }

    }


}
