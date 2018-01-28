using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Rigidbody2D missile;
    public float speed;


    // We don't need an update because once it starts, it just keeps going
    void Start()
    {
        //Gets the rigidbody of whatever this script is attached to 
        missile = GetComponent<Rigidbody2D>();

        //velocity of whatever this is attached to is:
        missile.velocity = speed * transform.right;
    }

}