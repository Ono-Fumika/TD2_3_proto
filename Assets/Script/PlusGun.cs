using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusGun : MonoBehaviour
{
    // +�e
    [SerializeField]
    PlusBullet plusBullet;

    // ���݂̃N�[���^�C��
    public float currentCoolTime = 0;
    // MAX�N�[���^�C��
    float coolTime = 1.5f;

    void Start()
    {
        
    }

    void Update()
    {
        // �N�[���^�C��������Ȃ猸�炷
        if(currentCoolTime > 0)
        {
            currentCoolTime -= Time.deltaTime;
        }
    }

    public void Shot(Quaternion plusGunDirection_)
    {
        // �N�[���^�C����0�Ȃ�
        if(currentCoolTime <= 0)
        {
            // �e�̐���
            Instantiate(plusBullet, new Vector3(0, 0, 0), plusGunDirection_);
            // �N�[���^�C����ݒ�
            currentCoolTime = coolTime;
        }
    }
}
