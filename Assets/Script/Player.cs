using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // +�e
    [SerializeField]
    PlusGun plusGun;
    // -�e
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
        // �E����������e�Ɏw��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("�v���X�e����");
            // �e�̌���
            Quaternion plusGunDirection = this.transform.rotation * Quaternion.Euler(0,90.0f,0);

            // �e�Ɍ�����n��
            plusGun.Shot(plusGunDirection);
        }

        // ������������e�Ɏw��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�}�C�i�X�e����");
            // �e�̌���
            Quaternion minusGunDirection = this.transform.rotation * Quaternion.Euler(0, -90.0f, 0);

            // �e�Ɍ�����n��
            minusGun.Shot(minusGunDirection);
        }
    }
}
