using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform fol;

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update () {
        this.transform.position = new Vector3(fol.position.x,fol.position.y,-100);
	}
}
