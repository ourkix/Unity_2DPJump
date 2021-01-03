using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


//	public float x_velocity;
	public float force_move = 50;  //移动
	private Animator anim;
	private bool isGround = false;
	public bool isWall = false;
	public float jumpVelocity = 10;
	private bool isSlide = false;
	private Transform wallTrans;
	public int jumpback = 3;
    public Rigidbody2D rigidbody2D;
    public int grivity = 30;
	void Awake(){
		anim = this.GetComponent<Animator>();          //判断动画run
		 
	}


	void Update () {
		Vector2 velocity = rigidbody2D.velocity;
	//移动控制
		float h = Input.GetAxis("Horizontal");  //获取水平方向，返回1.-1是以缓慢增加的值

		if(isSlide==false){

		if(h>0.05f){
			rigidbody2D.AddForce(Vector2.right*force_move);

		}
		else if(h<-0.05f){
			rigidbody2D.AddForce(-Vector2.right*force_move);

		}


		//按键人物方向
		if(h>0.05f){
			transform.localScale = new Vector3(1,1,1);   //人物向左
		}
		else if(h<-0.05f){
			transform.localScale = new Vector3(-1,1,1);  //人物向右
		}



		//判断run的动画
		anim.SetFloat("horizontal",Mathf.Abs(h));



		if(isGround && Input.GetKeyDown(KeyCode.Space)){
			//进行跳跃
			velocity.y = jumpVelocity;
			rigidbody2D.velocity=velocity;

            rigidbody2D.gravityScale = grivity;

		}


	
		anim.SetFloat("vertical",rigidbody2D.velocity.y);
	}

		else{
			//在滑行时可做的事情


			//进行跳跃
			if(Input.GetKeyDown(KeyCode.Space)){
				velocity.y = jumpVelocity;

		        //跳跃向后移动

				if(wallTrans.position.x < transform.position.x){    //判断角色和碰撞体的位置
					velocity.x = jumpback;
				}
				else{
					velocity.x = -jumpback;
				}   
			
				rigidbody2D.velocity=velocity;

			}

		
		}



		//控制角色是否在墙上
		if(isWall == false || isGround == true){
			isSlide = false;
		}



	}




	//与地面碰撞的检查   ，需要带入判定什么碰撞了  
	public void OnCollisionEnter2D(Collision2D col){
		if(col.collider.tag == "Ground"){
			isGround = true;
            rigidbody2D.gravityScale = grivity;
		}
		if(col.collider.tag == "Wall"){
			isWall = true;
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.gravityScale = 5;
			wallTrans = col.collider.transform;
		}
		anim.SetBool("isGround",isGround);  //将animetor里面的变量设置到代码的变量里面 isground
		anim.SetBool("isWall",isWall);

	} 
	public void OnCollisionExit2D(Collision2D col){
		if(col.collider.tag == "Ground"){
			isGround = false;
		}
		if(col.collider.tag == "Wall"){
			isWall = false;
            rigidbody2D.gravityScale = grivity;
		}
		anim.SetBool("isGround",isGround);  //将animetor里面的变量设置到代码的变量里面 isground
		anim.SetBool("isWall",isWall);


	} 
	 //更改朝向slid 
	public void ChangeDir(){
		isSlide = true;
		if(wallTrans.position.x < transform.position.x){
			transform.localScale = new Vector3(1,1,1);
		}
		else{
			transform.localScale = new Vector3(-1,1,1);
		}   
	
	}





}
