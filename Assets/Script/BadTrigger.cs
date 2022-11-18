using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameHandler.gameHandler.HiScore();
            //destroy the player
            Destroy(other.gameObject);
            GameHandler.gameHandler.Buttons();
        }
    }
}
