using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    checkpoint lastCheckpoint;

    private void Update()
    {
        if (transform.position.y <= -20)
        {
            print("gottaRespawn");
            GetComponent<playerRespawn>().respawn();
        }
    }

    public void addNewCheckpoint(checkpoint checkpoint)
    {
        lastCheckpoint = checkpoint;
    }

    public void respawn()
    {
        transform.position = lastCheckpoint.transform.position;
    }
}
