using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        TargetHP hitEnemy = otherGameObject.GetComponent<TargetHP>();

        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage();
        }
    }
}
