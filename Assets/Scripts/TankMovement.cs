using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

    public GameObject bulletCreate;
    public Transform bulletLo;

    public float force;
    public float speed;
    public float rotate;
	
	void Start ()
    {

	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward* speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotate * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotate * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

    void Shoot ()
    {
        var bullet = (GameObject)Instantiate(bulletCreate, bulletLo);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * force;
        Destroy(bullet, 5.0f);
    }
}
