using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    [SerializeField] Transform whereToGoRaw;
    Vector3 whereToGo;
    [SerializeField] float followSpeed = 5f;
    float cameraSize = 5f;
    private Vector3 velocity = Vector3.zero;


    private void FixedUpdate()
    {
        whereToGo = new Vector3(whereToGoRaw.position.x, whereToGoRaw.position.y, whereToGoRaw.position.z + -cameraSize);
        transform.position = Vector3.SmoothDamp(transform.position,whereToGo, ref velocity, followSpeed);
    }
}
