using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public static bool canSpawn = false;
    public GameObject spawnPos;
    public GameObject[] Balls;
    public GameObject[] ShootBalls = new GameObject[2];

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SpawnStart(0);
    }

    private void Start()
    {
    }

    public void SpawnStart(int i)
    {
        canSpawn = true;
        ShootBalls[i] = Instantiate(Balls[Random.Range(0, 9)], spawnPos.transform.position, Quaternion.identity);
        canSpawn = false;
    }

}
