//Student Name: Tran Thien Phu
//Student ID: 101160213
//Date Modifield: 20/10/2020




using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    public float horizontalSpeed;
    public float horizontalBoundary;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        //transform.position = new Vector3(0.0f, verticalBoundary);
        transform.position = new Vector3(horizontalBoundary,0.0f);
    }

    private void _Move()
    {
        //transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        //if (transform.position.y <= -verticalBoundary)
        //{
        //    _Reset();
        //}
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
