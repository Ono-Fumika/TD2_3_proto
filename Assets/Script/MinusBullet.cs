using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusBullet : MonoBehaviour
{
    // 移動スピード
    [SerializeField]
    float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
