using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (SpawnerController.instance.GetActiveRocket() != null)
            {
                var rocket = SpawnerController.instance.GetActiveRocket().GetComponent<RocketController>();
                rocket.Shoot();
            }
            else
                return;
                //StartCoroutine(_routine());
            }
	}

    IEnumerator _routine()
    {
        if (SpawnerController.instance.GetActiveRocket() != null)
        {
            var rocket = SpawnerController.instance.GetActiveRocket().GetComponent<RocketController>();
            rocket.Shoot();
            //yield return new WaitUntil(() => rocket.hasHit);
            SpawnerController.instance.SpawnRocket();
        }
        else
            yield return null;
    }
}
