using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2; // Time taken to Spawn new Pipe Obstacle
    private float timer = 0; // Timer that counts to create new Obstacle
    public float heightOffset = 5; // Offset Distance height between Pipes.

    // Start is called before the first frame update
    void Start()
    {
        createObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer += Time.deltaTime;    // Will increase the timer on every Frame.
        }
        else
        {
            createObstacle();
            timer = 0;
        }
    }

    void createObstacle()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate<GameObject>(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
