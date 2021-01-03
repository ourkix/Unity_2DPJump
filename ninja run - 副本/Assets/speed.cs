using UnityEngine;
using System.Collections;

public class speed : MonoBehaviour {

	public float speeds = 1000;
	// Update is called once per frame
	void Update () {
	 
		transform.Rotate(-Vector3.forward*speeds*Time.deltaTime);


	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "Player"){
			AudioManager._instance.PlayCollectible();
			Destroy(this.gameObject);
		}
	}
}
