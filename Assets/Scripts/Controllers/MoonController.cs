using UnityEngine;

public class MoonController : MonoBehaviour {


    public float rotationSpeed = 1f;
    public bool halfRotation = false;


    void Update () {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
	}
}
