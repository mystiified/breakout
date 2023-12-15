using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMech : MonoBehaviour
{
    Rigidbody BulletRigidBody;

    [SerializeField]
    GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        BulletRigidBody = prefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BulletRigidBody.position.y <= -0.25f)
        {
            Destroy(prefab);
            var position = new Vector3(Random.Range(-15.0f, 15.0f), 15, 0);
            Instantiate(prefab, new Vector3(0, 2, 0), Quaternion.identity);
            BulletRigidBody.AddForce(position);
        }
    }
}
