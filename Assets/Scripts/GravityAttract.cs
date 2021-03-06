﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttract : MonoBehaviour {
	public float gravity = -10f;
	public void Attract(Rigidbody body){
		Vector3 gravityUp = (body.position- transform.position).normalized;
		Vector3 localUp = body.transform.up;
		body.AddForce (gravityUp * gravity);
		body.rotation = Quaternion.FromToRotation (localUp, gravityUp) * body.rotation;

	}
		
}
