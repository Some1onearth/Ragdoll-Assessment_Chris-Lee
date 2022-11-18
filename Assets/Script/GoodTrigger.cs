using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameHandler.gameHandler.AddScore();
    }
}
