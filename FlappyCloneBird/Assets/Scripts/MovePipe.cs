using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float Speed;

    private void Start()
    {
    }

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;


    }
}
