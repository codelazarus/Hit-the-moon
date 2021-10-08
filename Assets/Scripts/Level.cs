using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Create Level", order = 1)]
public class Level : ScriptableObject {

    public GameObject moonPrefab;
    public float moonRotationSpeed;
    public bool halfMoonRotation;
    public int numberOfRockets;
}
