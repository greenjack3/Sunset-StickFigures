using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    bool isCrouching;
    Quaternion direction;
    public GameObject legs;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (vertical < 0)
            isCrouching = true;
        else
            isCrouching = false;

        if (horizontal < 0)
            direction = Quaternion.Euler(0, 180, 0);
        if (horizontal > 0)
            direction = Quaternion.Euler(0, 0, 0);

        legs.transform.rotation = direction;
    }
}
