//Student Name: Tran Thien Phu
//Student ID: 101160213
//Date Modifield: 20/10/2020


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();

        //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft && Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        //    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        //}
        transform.Rotate(0.0f, 0.0f, 270.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;

        //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        //    transform.position += new Vector3(verticalSpeed, verticalSpeed, 0.0f) * Time.deltaTime;
        //}
        transform.position += new Vector3(verticalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        //if (transform.position.y > verticalBoundary)
        //{
        //    bulletManager.ReturnBullet(gameObject);
        //}

        //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft && Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        //    if (transform.position.x > horizontalBoundary)
        //    {
        //        bulletManager.ReturnBullet(gameObject);
        //    }
        //}
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
