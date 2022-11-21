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
            //destroy all the player ragdoll objects tagged with "player"

            GameHandler.gameHandler.Buttons();
            Time.timeScale = 0;
        }
    }
}
