﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_n : MonoBehaviour {
	
	public float speed = 5;
	private Rigidbody2D _rigidbody2D;
	private Animator _animator;
	
	private float x;
	private float y;
	
	
	
	// Use this for initialization
	void Start () {
		
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis("Horizontal");
		y = Input.GetAxis("Vertical");
		
		if(x > 0)
		{
			_rigidbody2D.transform.eulerAngles = new Vector3(0,0,0);
			//_animator.SetValue("horizontal",x);
			_animator.SetBool("run",true);
			
		}
		if(x < 0)
		{
			_rigidbody2D.transform.eulerAngles = new Vector3(0,180,0);
			//_animator.SetValue("horizontal",x);
			_animator.SetBool("run",true);
			
		}
		if(x <0.001f && x>-0.001f)
		{
			_animator.SetBool("run",false);
			
		}
		Run();
	}
	
	
	private void Run()
	{
		Vector3 movement = new Vector3(x,y,0);
		_rigidbody2D.transform.position += movement * speed * Time.deltaTime;
		
		
		
	}
	
}
