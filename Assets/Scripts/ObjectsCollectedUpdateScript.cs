using UnityEngine;
using System.Collections;

public class ObjectsCollectedUpdateScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
	  int objects = GameObject.Find("GameManager").GetComponent<ObjectManager>().GetObjectCount();
    GetComponent<TextMesh>().text = "Objects Collected: " + objects.ToString();
	}
}
