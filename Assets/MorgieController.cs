using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorgieController : MonoBehaviour
{
    public float jumpUnit = 300;
    public float walkUnit = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * jumpUnit);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * jumpUnit);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0) * walkUnit) ;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0) * walkUnit);
        }
    }

}