using UnityEngine;
using System.Collections;

public class ItemBoxObjectScript : MonoBehaviour {

	public Transform player;
  public bool playerInside;

  private GameObject btnOverlay;

  void Start()
  {
    this.btnOverlay = gameObject.transform.Find("ButtonOverlay").gameObject;
  }

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
    if (playerInside)
    {
      btnOverlay.GetComponent<SpriteRenderer>().enabled = true;
    }else
    {
      btnOverlay.GetComponent<SpriteRenderer>().enabled = false;
    }
    if (playerInside == true && (Input.GetButtonDown("ActionButton") || Input.GetButtonDown("ActionController"))){
      GameObject.Find("GameManager").GetComponent<ObjectManager>().AddObject();
      Destroy(gameObject);
    }
  }
}
