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

    // �ړ��X�s�[�h
    [SerializeField]
    float moveSpeed = 5.0f;
    // ��]�X�s�[�h
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
        // �O�ɐi��
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        // ���ɉ�]
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        // �E�ɉ�]
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
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
