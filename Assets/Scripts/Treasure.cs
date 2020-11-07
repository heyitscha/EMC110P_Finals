using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    //***Public variables***//
    public int value = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GameManager.gm!=null)
            {
                //Notify the game manager to collect
                GameManager.gm.Collect (value);
            }

            //Explode if specified
            if (explosionPrefab !=  null)
            {
                Instantiate (explosionPrefab, transform.position, Quaternion.identity);
            }

            //destroy object once collected
            Destroy (gameObject);
        }
    }
}
