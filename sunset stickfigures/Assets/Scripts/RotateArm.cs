using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArm : MonoBehaviour {

    Quaternion direction;
    public GameObject head;
    public float blockingAngleL = -135f;
    public float blockingAngleR = -45f;

	void Start () 
	{
		
	}
	
	void Update () 
	{
        float switchingAngle = transform.rotation.eulerAngles.z;

        float horizontal = Input.GetAxis("Horizontal_right");
        float vertical = Input.GetAxis("Vertical_right");

        if (horizontal < 0)
            direction = Quaternion.Euler(0, 180, 0);
        if (horizontal > 0)
            direction = Quaternion.Euler(0, 0, 0);

        head.transform.rotation = direction;

        if (horizontal != 0 || vertical != 0)
        {
            float angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
            if(!(angle < blockingAngleR && angle > blockingAngleR))
                switchingAngle = angle;
        }

        transform.rotation = Quaternion.Euler(0, 0, switchingAngle);
    }
}
