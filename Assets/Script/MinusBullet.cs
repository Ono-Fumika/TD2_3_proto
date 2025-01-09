using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusBullet : MonoBehaviour
{
    // �ړ��X�s�[�h
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
