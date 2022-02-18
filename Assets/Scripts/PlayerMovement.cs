using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("moveLeft", true);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("moveRight", true);
        }
        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("moveUp", true);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("moveDown", true);
        }
        if (Input.GetKey("space"))
        {
            gameObject.transform.Translate(-250f * Time.deltaTime, 0, 0);
            // gameObject.GetComponent<Animator>().SetBool("moveDown", true);
        }




        if (!Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("moveLeft", false);
        }
        if (!Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moveRight", false);
        }
        if (!Input.GetKey("up"))
        {
            gameObject.GetComponent<Animator>().SetBool("moveUp", false);
        }
        if (!Input.GetKey("down"))
        {
            gameObject.GetComponent<Animator>().SetBool("moveDown", false);
        }

    }
}
