using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManegerr : MonoBehaviour
{
    [SerializeField]
    Player player;

    void Start()
    {
        
    }

    void Update()
    {
        // ÉvÉåÉCÉÑÅ[Çí«è]
        transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
