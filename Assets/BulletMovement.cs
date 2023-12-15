using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public int lives = 3;
    public bool quitswitch = false;

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
        BulletRigidBody.maxAngularVelocity = 0;
        if (quitswitch == false)
        {
            if (transform.position.y < -0.1346011)
            {
                RespawnFromBot();
                lives -= 1;
            }
            else if (lives == 0)
            {
                BulletRigidBody.velocity = Vector3.zero;
                quitswitch = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (quitswitch == false)
        {
            float speed = 11;
            BulletRigidBody.velocity = BulletRigidBody.velocity.normalized * speed;
        }

        if (quitswitch)
        {
            BulletRigidBody.velocity = Vector3.zero;
        }
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            UnityEngine.Debug.Log(Input.mousePosition);
        }
    }

    void RespawnFromBot()
    {
        transform.position = new Vector3(0, 2, 0);
        BulletRigidBody.velocity = Vector3.zero;
        BulletRigidBody.AddForce(new Vector3(Random.Range(-15.0f, 15.0f), 15, 0));
    }
}
