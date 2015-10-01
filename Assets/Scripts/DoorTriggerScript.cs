using UnityEngine;
using System.Collections;

public class DoorTriggerScript : MonoBehaviour {

public Transform player;
public Vector3 teleportTo;
public bool playerInside;
public Color col;


	void OnTriggerEnter2D(Collider2D other)
  {
    if (other.transform.tag == "Player")
    {
        playerInside = true;
        player = other.transform;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.transform.tag == "Player")
    {
        playerInside = false;
        player = null;
    }
  }

  void Update()
  {
      if (playerInside == true && (Input.GetButtonDown("ActionButton") || Input.GetButtonDown("ActionController"))){
          player.position = teleportTo;
      }
  }

  void OnDrawGizmos(){
    Gizmos.color = col;
    Gizmos.DrawWireSphere(teleportTo, .5f);
  }

}
