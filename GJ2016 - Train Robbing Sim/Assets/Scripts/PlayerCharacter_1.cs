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

        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire3"))
        {
            print("Punchy punchy");
        }

        if(Input.GetAxis("Horizontal") !=0)
        {
            HorizMove(Input.GetAxis("Horizontal"));
        }

        if(Input.GetAxis("Vertical") !=0)
        {
            VertMove(Input.GetAxis("Vertical"));
        }

    }
    
    void HorizMove(float i)
    {
        if (i < 0)
            print("Walky walky left");
        else if (i > 0)
        {
            print("Walky walky right");
        }
    }

    void VertMove(float i)
    {
        if (i < 0)
            print("Walky walky down");
        else if (i > 0)
        {
            print("Walky walky up");
        }
    }
}
