using UnityEngine;
using System.Collections;

public class MainBall : MonoBehaviour {


	public Rigidbody rb;	
	public float force = 0;
	private Vector3 wallrotation;

	public Transform originalObject;


	void Update () {

		Debug.Log (rb.velocity);
		Debug.Log (rb.velocity.normalized);
		if( Input.GetKeyDown(KeyCode.Space) )	
			
			{
				

			//	rb.velocity = new Vector3 (rb.velocity.x,0);
				rb.AddForce (new Vector3(1,1,0)*force*60);
					
				
			}
				}
	void OnCollisionEnter(Collision col) {

		Debug.Log (rb.velocity.normalized);
		float add = 0;
		wallrotation = col.transform.eulerAngles;
		//Debug.Log (wallrotation);

		if(col.gameObject.tag =="Wall"){

			rb.velocity = 8*Vector3.Reflect(new Vector3(1,1,0), col.contacts[0].normal);

//			add = rb.velocity.x;
//			if(rb.velocity.y>0){
//			rb.velocity = new Vector3(-add, rb.velocity.y, rb.velocity.z);
//			}
//			else{
//				rb.velocity = new Vector3(Mathf.Abs(add), rb.velocity.y, rb.velocity.z);
//			}
			//rb.velocity =  new Vector3(4, -7,2);
			//rb.velocity = ((rb.velocity.x+3),  rb.velocity.y, rb.velocity.z  ) ;         
}
	}}