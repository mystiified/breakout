using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody BulletRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidBody = GetComponent<Rigidbody>();
        BulletRigidBody.AddForce(new Vector3(Random.Range(-15.0f, 15.0f), 15, 0));

        float speed = 5;
        BulletRigidBody.velocity = BulletRigidBody.velocity.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -0.1346011)
        {
            transform.position = new Vector3(0, 2, 0);
            BulletRigidBody.velocity = Vector3.zero;
            BulletRigidBody.AddForce(new Vector3(Random.Range(-15.0f, 15.0f), 15, 0));
        }
    }
}
