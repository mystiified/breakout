using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    int health = 0;
    bool YNquit;

    [SerializeField]
    GameObject GameObject;

    TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        health = GameObject.Find("Sphere").GetComponent<BulletMovement>().lives;
        YNquit = GameObject.Find("Sphere").GetComponent<BulletMovement>().quitswitch;
    }

    // Update is called once per frame
    void Update()
    {
        
        string livesText = "Lives: " + health;
        textComponent.text = livesText;
    }
}
