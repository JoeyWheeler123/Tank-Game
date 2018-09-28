using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour {

    public GameObject cube;

    //public Transform cubeLo;

    void Start ()
    {
		for (int i = 0; i < 8; i++)
        {
            for( int x = 0; x < 8; x++)
            {
                GameObject clone;
                clone = Instantiate(cube, new Vector3(i * 3.0f, x * 3.0f, 0), Quaternion.identity);
                clone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
            }
        }
	}
	
	
	void Update () {
		
	}
}
