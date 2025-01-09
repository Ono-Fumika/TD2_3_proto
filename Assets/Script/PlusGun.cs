using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusGun : MonoBehaviour
{
    // +弾
    [SerializeField]
    PlusBullet plusBullet;

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
        if(currentCoolTime > 0)
        {
            currentCoolTime -= Time.deltaTime;
        }
    }

    public void Shot(Quaternion plusGunDirection_)
    {
        // クールタイムが0なら
        if(currentCoolTime <= 0)
        {
            // 弾の生成
            Instantiate(plusBullet, new Vector3(0, 0, 0), plusGunDirection_);
            // クールタイムを設定
            currentCoolTime = coolTime;
        }
    }
}
