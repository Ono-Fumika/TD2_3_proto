using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // +e
    [SerializeField]
    PlusGun plusGun;
    // -e
    [SerializeField]
    MinusGun minusGun;

    // ˆÚ“®ƒXƒs[ƒh
    [SerializeField]
    float moveSpeed = 5.0f;
    // ‰ñ“]ƒXƒs[ƒh
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
        // ‘O‚Éi‚Ş
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        // ¶‚É‰ñ“]
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        // ‰E‚É‰ñ“]
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }

    void Shot()
    {
        // ‰E‚ğ‰Ÿ‚µ‚½‚çe‚Éw—ß
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("ƒvƒ‰ƒX’e”­Ë");
            // e‚ÌŒü‚«
            Quaternion plusGunDirection = this.transform.rotation * Quaternion.Euler(0,90.0f,0);

            // e‚ÉŒü‚«‚ğ“n‚·
            plusGun.Shot(plusGunDirection);
        }

        // ¶‚ğ‰Ÿ‚µ‚½‚çe‚Éw—ß
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("ƒ}ƒCƒiƒX’e”­Ë");
            // e‚ÌŒü‚«
            Quaternion minusGunDirection = this.transform.rotation * Quaternion.Euler(0, -90.0f, 0);

            // e‚ÉŒü‚«‚ğ“n‚·
            minusGun.Shot(minusGunDirection);
        }
    }
}
