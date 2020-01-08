using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOBehavior : MonoBehaviour
{
    public float speed;
    public float bottomBounds;
    public float yBounds;
    public float topBounds;

    private Vector3 move = new Vector3(-1f, 0f, 0f);



    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime * speed;

        if (transform.position.x < bottomBounds)
        {
            transform.position = new Vector3(topBounds, Random.Range(-yBounds, yBounds), 0f);
        }


    }


}


