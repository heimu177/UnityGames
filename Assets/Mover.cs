using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float y = 0.0f;
    [SerializeField] float z = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(-5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate(x, y, z);
    }
}
