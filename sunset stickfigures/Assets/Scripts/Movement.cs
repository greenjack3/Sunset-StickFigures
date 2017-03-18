using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    bool isCrouching;
    Quaternion direction;
    public GameObject legs;

    void Start()
    {
       
    } 

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (vertical < 0)
            isCrouching = true;
        else
            isCrouching = false;

        if (horizontal < 0)
            direction = Quaternion.Euler(0, 0, 0);
        if (horizontal > 0)
            direction = Quaternion.Euler(0, 180, 0);

        legs.transform.rotation = direction;

        transform.Translate(new Vector3(speed * horizontal * Time.deltaTime, 0, 0));
    }
}
