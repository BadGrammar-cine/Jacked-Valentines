using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suisei_Slingshooter : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(Vector3.forward * speed);
            Destroy(instBullet, 10f);
            //transform.Translate(new Vector3(1f, 20f, 0f) * speed * Time.deltaTime); - for making it rotate
        }
    }
}
