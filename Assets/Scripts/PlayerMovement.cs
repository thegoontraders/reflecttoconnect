using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

  public string horizontalAxisInput = "Horizontal";
  public string actionButtonInput = "Fire1";

  public float maxSpeed = 0f;
  public float baseSpeed = 0f;
  public Rigidbody2D rigidbody;

  public bool isWalking = false;
	
	void FixedUpdate ()
  {
    baseSpeed = Input.GetAxis(horizontalAxisInput);
    if (baseSpeed > 0){ isWalking = true; }else{ isWalking = false; }
    rigidbody.velocity = new Vector2(baseSpeed * maxSpeed, rigidbody.velocity.y);
	}
}
