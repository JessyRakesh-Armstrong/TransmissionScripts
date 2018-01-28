using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {

    void OnTriggerExit2D(Collider2D other)
    {
        //Destroys any game object this collides with. 
        Destroy(GameObject.FindGameObjectWithTag("Player"));
    }
}
