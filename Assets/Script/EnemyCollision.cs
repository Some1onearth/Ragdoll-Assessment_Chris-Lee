using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //are we touching the player?
        if (collision.gameObject.tag == "Player")
        {
            GameHandler.gameHandler.MinusScore();
        }
        Debug.Log(collision.gameObject.name);
    }
}
