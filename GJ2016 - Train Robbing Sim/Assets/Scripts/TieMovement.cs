﻿using UnityEngine;
using System.Collections;

public class TieMovement : MonoBehaviour {

    public GameObject Tie;

	// Use this for initialization
	void Start () {
        Tie.transform.position = new Vector3(13.25f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Tie.transform.position = new Vector3(Tie.transform.position.x - 0.1f, Tie.transform.position.y, Tie.transform.position.z);
        if (Tie.transform.position.x <= -13.25f)
        {
            Destroy(Tie);
        }
	}
}