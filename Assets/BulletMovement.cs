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
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 15;
        BulletRigidBody.velocity = BulletRigidBody.velocity.normalized * speed;
    }
}
