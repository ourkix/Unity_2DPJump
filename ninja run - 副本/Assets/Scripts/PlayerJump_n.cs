using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump_n : MonoBehaviour {
	
	public float jumpVelocity = 5f;
	
	private Rigidbody2D _rigidbody2D;
	private bool jumpRequest = false;
	//private Animator _animator;
	
	// Use this for initialization
	void Start () {
		
		_rigidbody2D = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Jump"))
		{
			jumpRequest = true;
			
		}
		
		
	}
	
	private void FixedUpdate()
	{
		if(jumpRequest)
		{
			_rigidbody2D.AddForce(Vector2.up * jumpVelocity,ForceMode2D.Impulse);
			jumpRequest = false;
			
		}
		
	}
	
	
}
