using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class endScreenScript : MonoBehaviour
{
    bool YNquit = false;

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
        YNquit = GameObject.Find("Sphere").GetComponent<BulletMovement>().quitswitch;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "";

        if (YNquit == true && gameObject.name == "death screen")
        {
            textComponent.text = "You Lost!";
        } else if (YNquit == true && gameObject.name == "quit text")
        {
            textComponent.text = "press any key to quit";
            if (Input.anyKey)
            {
                Application.Quit(); 
            }
        }
    }
}
