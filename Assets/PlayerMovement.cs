using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool YNquit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        YNquit = GameObject.Find("Sphere").GetComponent<BulletMovement>().quitswitch;

        if (YNquit == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = gameObject.transform.position + new Vector3(-0.3f, 0, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position = gameObject.transform.position + new Vector3(0.3f, 0, 0);
            }

            if (gameObject.transform.position.x < -17.5f)
            {
                transform.position = new Vector3(-17.5f, 0, 0);
            }

            if (gameObject.transform.position.x > 17.5f)
            {
                transform.position = new Vector3(17.5f, 0, 0);
            }
        }
    }
}
