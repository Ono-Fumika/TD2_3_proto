using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusBullet : MonoBehaviour
{
    // 移動スピード
    [SerializeField]
    float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // 弾移動
        Move();
        // 画面外に出たら消滅
        CheckIfOffScreen();
    }

    private void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void CheckIfOffScreen()
    {
        // メインカメラを取得
        Camera mainCamera = Camera.main;
        // オブジェクトの画面内位置を取得
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
        // オブジェクトが外に出たかチェック
        if (viewportPosition.x < 0 || viewportPosition.x > 1 || viewportPosition.y < 0 || viewportPosition.y > 1)
        {
            Destroy(gameObject);
        }
    }
}
