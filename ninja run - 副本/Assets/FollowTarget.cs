using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {


	public Transform target;

	// Update is called once per frame
	void Update () {
	
		Vector3 pos = transform.position;
		
		Vector3 m = new Vector3(target.position.x,target.position.y,0);
		Vector3 v = m -  new Vector3(pos.x,pos.y,0);
		//float distance = Vector3.magnitude(v);
		
		Vector3 pox = new Vector3(0,0,0);
		
		pox = transform.position;
		
		pox.x += (float)v.x  * (float)0.05;
		pox.y += (float)v.y  * (float)0.05;
		
		
		transform.position = pox;

	/*	if(target.position.y>22f){
			pos.y = target.position.y;
		}
		else if(target.position.y<15f){
			pos.y = target.position.y;
		}
*/

	}
}

