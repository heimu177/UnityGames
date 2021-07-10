using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rbd;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;

        _rbd = GetComponent<Rigidbody>();
        _rbd.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _renderer.enabled = true;
            _rbd.useGravity = true;
        }
    }
}
