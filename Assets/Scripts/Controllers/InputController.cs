using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SpawnerController.instance.GetActiveRocket() != null)
            {
                var rocket = SpawnerController.instance.GetActiveRocket().GetComponent<RocketController>();
                rocket.Shoot();
            }
            else
                return;
        }
    }
}
