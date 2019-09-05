using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	
	// Update is called once per frame & Time.deltaTime is used for smoothness and framerate independency
	void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
