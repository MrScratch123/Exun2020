using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            collider.GetComponent<playerRespawn>().addNewCheckpoint(pos);
        }
    }
}
