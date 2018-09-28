using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMove : MonoBehaviour {

	private float radius = 5;
	private int numWayPoints = 6;

	public List<Vector3> waypoints = new List<Vector3>();

	void Start () 
	{
		float pointPos = (Mathf.PI * 2.0f) / numWayPoints;

		for (int i = 0; i < numWayPoints; i++)
		{
			
			float angle = i * pointPos;
			Vector3 waypoint = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
			waypoint = transform.TransformPoint(waypoint);
			waypoints.Add(waypoint);
			//Gizmos.color = Color.yellow;
			//Gizmos.DrawSphere(waypoint, 1);
                        
		}

		
	}
	

	void Update () 
	{
		
	}
}
