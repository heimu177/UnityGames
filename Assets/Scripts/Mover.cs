using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Wiki();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Wiki()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("WASD to move around and try not to hit the walls!");
        Debug.Log("Enjoy the game!");
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, 0, z);
    }
}
