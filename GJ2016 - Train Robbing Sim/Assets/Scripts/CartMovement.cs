using UnityEngine;
using System.Collections;

public class CartMovement : MonoBehaviour {


    public GameObject Cart;
    private bool isOffset = false;
    private float lastShake = 0f;
    private Vector3 OrigPos;
    // Use this for initialization
    void Start () {
        OrigPos = Cart.transform.position = Vector3.zero;
        Random.InitState((int)Time.time);

    }
	
	// Update is called once per frame
	void Update () {
        if (isOffset)
        {
            Cart.transform.position = OrigPos;
            isOffset = false;
        }
        else if (Time.time >= lastShake + 5)
        {
            Cart.transform.position = new Vector3(Cart.transform.position.x, Cart.transform.position.y + 0.1f, Cart.transform.position.z);
            lastShake = Time.time;
            isOffset = true;
        }
        
    }
}
