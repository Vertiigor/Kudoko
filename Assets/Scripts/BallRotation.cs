using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject center;
    bool direction = false;

    void FixedUpdate()
    {
        if (direction)
        {
            center.transform.Rotate(0, 0, 150 * Time.deltaTime);
        }
        else
        {
            center.transform.Rotate(0, 0, -150 * Time.deltaTime);
        }
    }

    public void ChangeDirection()
    {
        this.direction = !direction;
    }
}
