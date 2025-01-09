using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusBullet : MonoBehaviour
{
    // �ړ��X�s�[�h
    [SerializeField]
    float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // �e�ړ�
        Move();
        // ��ʊO�ɏo�������
        CheckIfOffScreen();
    }

    private void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void CheckIfOffScreen()
    {
        // ���C���J�������擾
        Camera mainCamera = Camera.main;
        // �I�u�W�F�N�g�̉�ʓ��ʒu���擾
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
        // �I�u�W�F�N�g���O�ɏo�����`�F�b�N
        if (viewportPosition.x < 0 || viewportPosition.x > 1 || viewportPosition.y < 0 || viewportPosition.y > 1)
        {
            Destroy(gameObject);
        }
    }
}
