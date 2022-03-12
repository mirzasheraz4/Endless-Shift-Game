using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    public float valuex = 0.05f;
    public float valuey = 0.05f;
    public float valuez = -0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.localScale = new Vector3(1, 5, -3);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKey(KeyCode.DownArrow) )
        {

            transform.localScale = new Vector3(5, 1, 1);

        }
    }
}
