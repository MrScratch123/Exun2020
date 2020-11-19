using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float start = -1400;
    [SerializeField] float stop = 1100;
    private void Start()
    {
        transform.position = new Vector2(transform.position.x, start);
    }
    void Update()
    {
        if (transform.position.y <= stop)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                FindObjectOfType<loadMenu>().gameObject.GetComponent<Animator>().SetTrigger("boom");
            }

            if(SceneManager.GetActiveScene().buildIndex == 6)
            {
                print("bye bye");
                Application.Quit();
            }
        }
    }
}
