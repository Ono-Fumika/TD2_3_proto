using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusGun : MonoBehaviour
{
    // -弾
    [SerializeField]
    MinusBullet minusBullet;

    // 現在のクールタイム
    public float currentCoolTime = 0;
    // MAXクールタイム
    float coolTime = 1.5f;

    void Start()
    {

    }

    void Update()
    {
        // クールタイムがあるなら減らす
        if (currentCoolTime > 0)
        {
            currentCoolTime -= Time.deltaTime;
        }
    }

    public void Shot(Quaternion minusGunDirection_)
    {
        // クールタイムが0なら
        if (currentCoolTime <= 0)
        {
            // 弾の生成
            Instantiate(minusBullet, new Vector3(0, 0, 0), minusGunDirection_);
            // クールタイムを設定
            currentCoolTime = coolTime;
        }
    }
}
