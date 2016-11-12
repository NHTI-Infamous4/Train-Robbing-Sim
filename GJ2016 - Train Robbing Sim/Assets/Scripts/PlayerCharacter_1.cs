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

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Punchy punchy");
        }

        if(Input.GetAxis("Horizontal") !=0)
        {
            if(Input.GetAxis("Horizontal") <0)
            print("Walky walky left");
            else if(Input.GetAxis("Horizontal") > 0)
            {
                print("Walky walky right");
            }
        }

        if(Input.GetAxis("Vertical") !=0)
        {
            if (Input.GetAxis("Vertical") < 0)
                print("Walky walky down");
            else if (Input.GetAxis("Vertical") > 0)
            {
                print("Walky walky up");
            }
        }

    }  
}
