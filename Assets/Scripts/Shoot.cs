using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public static Shoot instance;
    public static bool canShoot = true;
    public GameObject shootPos;
    public GameObject Balls;
    public int Speed;

    private float z = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        ReadyShoot();
    }

    private void Update()
    {
        z -= Time.deltaTime * Speed * Input.GetAxis("Horizontal");

        z = Mathf.Clamp(z, -80, 80);

        gameObject.transform.rotation = Quaternion.Euler(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Fire!@");
            canShoot = false;
            float moveX = 3.0f * Time.deltaTime;
            SpawnManager.instance.ShootBalls[1].transform.Translate(0, moveX, 0);

        }
    }

    public void ReadyShoot()
    {
        canShoot = true;
        SpawnManager.instance.ShootBalls[1] = SpawnManager.instance.ShootBalls[0];
        SpawnManager.instance.ShootBalls[1].transform.position = gameObject.transform.position;
        SpawnManager.instance.SpawnStart(0);
    }

    public void GoShoot()
    {
        canShoot = false;
        SpawnManager.canSpawn = false;

    }
}
