using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour {

    public void MoveHorizontaly(float speed, float axisHorizontal, Transform objectToMove)
    {
        if (axisHorizontal > 0)
        {
            objectToMove.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if(axisHorizontal < 0)
        {
            objectToMove.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    public void MoveVerticaly(float speed, float axisVertical, Transform objectToMove)
    {
        if (axisVertical > 0)
        {
            objectToMove.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (axisVertical < 0)
        {
            objectToMove.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
