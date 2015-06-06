using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Block(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
