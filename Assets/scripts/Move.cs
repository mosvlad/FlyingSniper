 using UnityEngine;
 using System.Collections;
  
 public class Move : MonoBehaviour
  
 {
	 
  public float moveSpeed = 2.5f;
		
         void Update ()
         {
                 if (Input.GetKey(KeyCode.LeftArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x -= moveSpeed;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.RightArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x += moveSpeed;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.UpArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.y += moveSpeed;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.DownArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.y -= moveSpeed;
                         this.transform.position = position;
                 }
 }
 }