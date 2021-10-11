using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonController : MonoBehaviour {


    public float rotationSpeed = 1f;
    public bool halfRotation = false;

    // Update is called once per frame
    void Update () {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
	}
}
