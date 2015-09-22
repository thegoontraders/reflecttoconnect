using UnityEngine;
using System.Collections;

public class DoorTriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
  
  void OnCollisionEnter2D (Collision2D coll)
  {
    if (coll.gameobject.tag == "Player")
    {
      GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
      
    }
  }
}
