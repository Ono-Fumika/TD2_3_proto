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
