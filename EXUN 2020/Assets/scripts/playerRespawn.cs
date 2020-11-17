using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    Vector2 lastCheckpoint;
    [SerializeField] Canvas checkpointCanvas;
    List<Vector2> checkpointsList = new List<Vector2>();
    List<Vector2> allCheckPoints = new List<Vector2>();


    private void Start()
    {
        lastCheckpoint = new Vector2(PlayerPrefs.GetFloat("xPos", 0) + 2, PlayerPrefs.GetFloat("yPos", 0));
        transform.position = lastCheckpoint;
        var checkPointsArray = FindObjectsOfType<checkpoint>();
        foreach(checkpoint checkpoint in checkPointsArray)
        {
            Vector2 posToAdd = new Vector2(checkpoint.transform.position.x, checkpoint.transform.position.y);
            allCheckPoints.Add(posToAdd);
        }
        allCheckPoints.Reverse();
        var lastSavedCheckPoint = new Vector2(lastCheckpoint.x - 2, lastCheckpoint.y);
        for(int i = 0; i <= allCheckPoints.IndexOf(lastSavedCheckPoint); i = i + 1)
        {
            checkpointsList.Add(allCheckPoints[i]);
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
