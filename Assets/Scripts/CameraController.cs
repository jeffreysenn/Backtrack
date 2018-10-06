using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // Use this for initialization
    public GameObject Target;

    private Vector3 offset;
	void Start ()
    {
        offset = transform.position - Target.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Target == null)
        {
            Debug.LogError(gameObject.name + " has no target to follow");
            return;
        }
	}

    void LateUpdate()
    {
        transform.position = Target.transform.position + offset;
    }
}
