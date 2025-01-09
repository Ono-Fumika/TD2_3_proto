using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusGun : MonoBehaviour
{
    // -�e
    [SerializeField]
    MinusBullet minusBullet;

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
        if (currentCoolTime > 0)
        {
            currentCoolTime -= Time.deltaTime;
        }
    }

    public void Shot(Quaternion minusGunDirection_)
    {
        // �N�[���^�C����0�Ȃ�
        if (currentCoolTime <= 0)
        {
            // �e�̐���
            Instantiate(minusBullet, new Vector3(0, 0, 0), minusGunDirection_);
            // �N�[���^�C����ݒ�
            currentCoolTime = coolTime;
        }
    }
}
