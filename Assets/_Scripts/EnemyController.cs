//Student Name: Tran Thien Phu
//Student ID: 101160213
//Date Modifield: 20/10/2020



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;
    public float verticalBoundary;
    public float verticalSpeed;

    void Start()
    {
        transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }


    private void _CheckBounds()
    {
        // check right boundary
        //if (transform.position.x >= horizontalBoundary)
        //{
        //    direction = -1.0f;
        //}

        //// check left boundary
        //if (transform.position.x <= -horizontalBoundary)
        //{
        //    direction = 1.0f;
        //}
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
