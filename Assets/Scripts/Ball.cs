using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int stack;
    public int moveSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float moveX = moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, 0);
    }
}
