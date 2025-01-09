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

    void Start()
    {
        
    }

    void Update()
    {
        Shot();
    }

    void Move()
    {
       
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
