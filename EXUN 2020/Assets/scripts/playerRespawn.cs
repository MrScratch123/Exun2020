using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    Vector2 lastCheckpoint;
    [SerializeField] Canvas checkpointCanvas;
    List<Vector2> checkpointsList = new List<Vector2>();
    [SerializeField] List<checkpoint> allCheckPoints = new List<checkpoint>();


    private void Start()
    {
        lastCheckpoint = new Vector2(PlayerPrefs.GetFloat("xPos", 0) + 2, PlayerPrefs.GetFloat("yPos", 0));
        transform.position = lastCheckpoint;
        List<Vector2> allCheckPointsPos = new List<Vector2>();
        foreach (checkpoint checkpoint in allCheckPoints)
        {
            Vector2 posToAdd = new Vector2(checkpoint.transform.position.x, checkpoint.transform.position.y);
            allCheckPointsPos.Add(posToAdd);
        }
        var lastSavedCheckPoint = new Vector2(lastCheckpoint.x - 2, lastCheckpoint.y);
        for (int i = 0; i <= allCheckPointsPos.IndexOf(lastSavedCheckPoint); i = i + 1)
        {
            checkpointsList.Add(allCheckPointsPos[i]);
        }
        print(checkpointsList.Count);
    }

    private void Update()
    {
        if (transform.position.y <= -20)
        {
            GetComponent<playerRespawn>().respawn();
        }
    }

    public void addNewCheckpoint(Vector2 checkpoint)
    {
        if (checkpointsList.Contains(checkpoint) == false)
        {
            checkpointsList.Add(checkpoint);
            lastCheckpoint = checkpoint;
            PlayerPrefs.SetFloat("xPos", lastCheckpoint.x);
            PlayerPrefs.SetFloat("yPos", lastCheckpoint.y);
            PlayerPrefs.Save();
            checkpointCanvas.GetComponent<Animator>().SetTrigger("show");
        }
    }

    public void respawn()
    {
        transform.position = new Vector3(lastCheckpoint.x, lastCheckpoint.y, 0f);
    }


}
