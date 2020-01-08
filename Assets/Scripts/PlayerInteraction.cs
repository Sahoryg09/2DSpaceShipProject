using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    public float speed;
    public ScoreScript scoreScript;




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("s") && transform.position.y > -8)
        {
            Vector3 move = new Vector3(0f, -1f, 0f);
            this.transform.position += move * Time.deltaTime * speed;
        }


        if (Input.GetKey("w") && transform.position.y < 8)
        {
            Vector3 move = new Vector3(0f, 1f, 0f);
            this.transform.position += move * Time.deltaTime * speed;
        }
      
        if (Input.GetKey("a") && transform.position.y > -8)
        {
            Vector3 move = new Vector3(-1f, 0f, 0f);
            this.transform.position += move * Time.deltaTime * speed;
        }


        if (Input.GetKey("d") && transform.position.y < 8)
        {
            Vector3 move = new Vector3(1f, 0f, 0f);
            this.transform.position += move * Time.deltaTime * speed;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you have been hit");
        scoreScript.UpdatePlayersLives(-1);
    }









}
