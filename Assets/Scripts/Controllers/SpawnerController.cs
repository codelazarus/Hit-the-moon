using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public static SpawnerController instance;

    public GameObject rocketPrefab;
    private GameObject _activeRocket = null;

    public int numberOfSpawnedRockets = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void SpawnRocket()
    {
        if (!CheckRocketsGoal())
        {
            numberOfSpawnedRockets++;
            _activeRocket = Instantiate(rocketPrefab);
            _activeRocket.transform.parent = transform;
            _activeRocket.transform.localPosition = new Vector3(0, 0, 0);
        }
        else
            GameManager.instance.OnLevelPassed();
    }

    internal void Reload()
    {
        numberOfSpawnedRockets = 0;
        foreach (Transform rockets in transform)
        {
            Destroy(rockets.gameObject);
        }
        SpawnRocket();
    }

    public bool CheckRocketsGoal()
    {
        if (numberOfSpawnedRockets == LevelManager.instance.rocketsGoal)
            return true;
        else
            return false;
        
    }

    public GameObject GetActiveRocket()
    {
        return _activeRocket;
    }
}
