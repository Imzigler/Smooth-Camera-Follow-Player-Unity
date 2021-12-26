using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;
	public float smoothspeed;
	
	
	// LateUpdate is called every frame, if the Behaviour is enabled.
	protected void LateUpdate()
	{
		Vector3 diseredposition = player.position + offset;
		Vector3 smoothedposition = Vector3.Slerp(transform.position,diseredposition,smoothspeed);
		transform.position = smoothedposition;
		transform.LookAt(player);
	}
}
