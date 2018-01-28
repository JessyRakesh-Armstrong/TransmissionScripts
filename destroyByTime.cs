using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByTime : MonoBehaviour
{

    public float lifeTime;

    // Use this for initialization
    void Start()
    {

        //Destroys the object after their lifeTime is up
        //We do this so we don't have a lot of objects just floating around
        Destroy(gameObject, lifeTime);
    }

}
