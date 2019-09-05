using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - Player.transform.position;
	}
	
	// LateUpdate is called once per frame but is guaranteed to run after all objects has been processed in update
	void LateUpdate ()
    {
        transform.position = Player.transform.position + offset;
	}
}
