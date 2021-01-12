using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontroler : MonoBehaviour {
	
	public GameObject gamepanle;	
	
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
	
	
	public void GamePanleRestart(string levele)
	{
		SceneManager.LoadScene(levele);
		
		
	}
	
	public void showGamePanle()
	{
		gamepanle.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
		
		
	}
}
