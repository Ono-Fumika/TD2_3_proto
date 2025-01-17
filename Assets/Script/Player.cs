using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // +銃
    [SerializeField]
    PlusGun plusGun;
    // -銃
    [SerializeField]
    MinusGun minusGun;

    // 移動スピード
    [SerializeField]
    float moveSpeed = 5.0f;
    // 回転スピード
    [SerializeField]
    float rotationSpeed = 100.0f;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        Shot();
    }

    void Move()
    {
        // 前に進む
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        // 左に回転
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        // 右に回転
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }

    void Shot()
    {
        // 右を押したら銃に指令
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("プラス弾発射");
            // 銃の向き
            Quaternion plusGunDirection = this.transform.rotation * Quaternion.Euler(0,90.0f,0);

            // 銃に向きを渡す
            plusGun.Shot(plusGunDirection);
        }

        // 左を押したら銃に指令
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("マイナス弾発射");
            // 銃の向き
            Quaternion minusGunDirection = this.transform.rotation * Quaternion.Euler(0, -90.0f, 0);

            // 銃に向きを渡す
            minusGun.Shot(minusGunDirection);
        }
    }
}
