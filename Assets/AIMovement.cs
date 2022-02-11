using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    // create the variable
    // place data in the variable
    // use the variable

    public GameObject position0;
    public GameObject position1;

    // Update is called once per frame
    void Update()
    {
        Vector2 AIPosition = (Vector2)transform.position;
        /*
        // METHOD 1
        // If cube is on the left
        if (transform.position.x < position0.transform.position.x)
        {
            //move right
            AIPosition.x += (.8f * Time.deltaTime);
            transform.position = AIPosition;
        }
        else
        {
            //move left
            AIPosition.x -= (.8f * Time.deltaTime);
            transform.position = AIPosition;
        }


        //METHOD 2
        if (transform.position.y < position0.transform.position.y)
        {
            transform.position += (Vector3)Vector2.up * 1 * Time.deltaTime;

        }
        else
        {
            transform.position -= (Vector3)Vector2.up * 1 * Time.deltaTime;
        }*/


        Vector2 directionToPosition0 = (Vector2)(position0.transform.position - transform.position);
        directionToPosition0.Normalize();
        transform.position += (Vector3)directionToPosition0 * 1 * Time.deltaTime;
    }
}
