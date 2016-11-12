using UnityEngine;
using System.Collections;

public class PlayerCharacter_1 : MonoBehaviour {

    public int Health;
    public int Money;


	// Use this for initialization
	void Start () {

        Health = 100;
        Money = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            print("Walky walky up");
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            print("Walky walky down");
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            print("Walky walky left");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            print("Walky walky right");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Punchy punchy");
        }

    }  
}
