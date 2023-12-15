using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody PlayerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            PlayerRigidBody.AddForce(new Vector3(-15, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            PlayerRigidBody.AddForce(new Vector3(15, 0, 0));
        }
    }
}
