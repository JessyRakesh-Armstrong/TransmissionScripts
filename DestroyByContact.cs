using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "Ground")
        {
            if(other.tag == "Projectile")
            {
                Destroy(other.gameObject);
            }
            return;//this way the boundary and asteroid don't break each other
        }
        if (other.tag == "Projectile")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);//destroys thing this script is attached to
                                //Instantiate(explosion, transform.position, transform.rotation);

        }


    }
}
