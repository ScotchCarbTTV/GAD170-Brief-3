using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //reference to the rigidbody
    [SerializeField] Rigidbody rBody;

    [SerializeField] float bulletSpeed;

    [SerializeField] float bulletLife;


    private void Update()
    {
        bulletLife -= 1 * Time.deltaTime;
        if(bulletLife <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void BulletShoot(Vector3 forward)
    {
        transform.eulerAngles = forward;

        rBody.AddForce(forward * bulletSpeed);
    }
}
