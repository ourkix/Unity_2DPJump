using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroler : MonoBehaviour {
	
	
	public int totalScore;
	public Text ScoreText;
	
	public static gamecontroler Instance;
	
	// Use this for initialization
	void Start () {
		
		Instance = this;
		
		
		
		
		
	}
	public void  UpdateTotalScore()
	{
		this.ScoreText.text = totalScore.ToString();
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
		
		
		
		
	}
}
