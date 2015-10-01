using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

  public int objectsCollected = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void AddObject()
  {
    this.objectsCollected += 1;
  }

  public void RemoveObject()
  {
    this.objectsCollected -= 1;
  }

  public int GetObjectCount()
  {
    return this.objectsCollected;
  }

}
