using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameHandler.gameHandler.AddScore();
            Destroy(this);
        }
    }
}
