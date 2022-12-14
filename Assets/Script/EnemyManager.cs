using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform pointA;
    public Transform pointB;
    public float spawnTime, repeatRate; //use this for InvokeRepeating spawn rate

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Vector3 spawnPos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f)); //lerp 
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}
