using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatfrom : MonoBehaviour {
	
	public float fallingTime = 3f;
	
	private TargetJoint2D _targetJoint2D;
	private BoxCollider2D _boxCollider2D;
	
	// Use this for initialization
	void Start () {
		_targetJoint2D = GetComponent<TargetJoint2D>();
		_boxCollider2D = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Invoke("Falling",fallingTime);
			
		}
		
	}
	
	private void Falling()
	{
		_targetJoint2D.enabled = false;
		_boxCollider2D.isTrigger = false;
		
	}
	
	
}
