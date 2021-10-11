using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;

    public Level[] levels;

    public int rocketsGoal;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void LoadLevel(int levelIndex)
    {
        Level level = levels[levelIndex];

        GameObject moon = Instantiate(level.moonPrefab);

        var moonController = moon.GetComponent<MoonController>();
        moonController.rotationSpeed = level.moonRotationSpeed;
        moonController.halfRotation = level.halfMoonRotation;
        moon.transform.parent = transform.parent;

        rocketsGoal = level.numberOfRockets;
    }
}
