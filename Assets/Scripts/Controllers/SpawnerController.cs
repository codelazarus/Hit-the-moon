using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public static SpawnerController instance;

    public GameObject rocketPrefab;
    [SerializeField]
    private GameObject _activeRocket = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void OnEnable()
    {
        if (_activeRocket == null)
        {
            SpawnRocket();
        }
    }
    public void SpawnRocket()
    {
        _activeRocket = Instantiate(rocketPrefab);
        _activeRocket.transform.parent = transform;
        _activeRocket.transform.localPosition = new Vector3(0, 0, 0);
    }

    public GameObject GetActiveRocket()
    {
        return _activeRocket;
    }

    private void OnDisable()
    {
        foreach (Transform rockets in transform)
        {
            Destroy(rockets.gameObject);
        }
    }
}
