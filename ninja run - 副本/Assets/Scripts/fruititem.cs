using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruititem : MonoBehaviour {
	
	public GameObject collectedEffect;
	
	private SpriteRenderer _spriteRenderer;
	private CircleCollider2D _circleCollider2D;
	
	public int Score = 100;
	
	// Use this for initialization
	void Start () {
		
		_spriteRenderer  = GetComponent<SpriteRenderer>();
		_circleCollider2D = GetComponent<CircleCollider2D>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag  == "Player")
		{
			_spriteRenderer.enabled = false;
			_circleCollider2D.enabled = false;
			
			collectedEffect.SetActive(true);
			
			gamecontroler.Instance.totalScore += Score;
			gamecontroler.Instance.UpdateTotalScore();
			
			Destroy(gameObject , 0.7f);
			
		}
		
	}
	
}
