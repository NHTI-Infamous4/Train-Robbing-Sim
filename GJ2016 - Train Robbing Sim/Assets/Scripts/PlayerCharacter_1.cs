using UnityEngine;

public class PlayerCharacter_1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cart;
    public int Health;
    public int Money;
    private bool isOffset = false;
    private float lastShake = 0f;
    private Vector3 OrigPos;

    // Use this for initialization
    private void Start()
    {
        Health = 100;
        Money = 0;
        OrigPos = Cart.transform.position = Vector3.zero;
        Random.InitState((int)Time.time);
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
        if(isOffset)
        {
            Cart.transform.position = OrigPos;
            isOffset = false;
        }
        else if(Time.time >= lastShake + 5)
        {
            Cart.transform.position = new Vector3(Cart.transform.position.x, Cart.transform.position.y + 0.1f, Cart.transform.position.z);
            lastShake = Time.time;
            isOffset = true;
        }
        if(Health <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire3"))
        {
            print("Punchy punchy");
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            float f = Input.GetAxis("Horizontal");
            Player.transform.position = new Vector3(Player.transform.position.x + f, Player.transform.position.y, Player.transform.position.z);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float f = Input.GetAxis("Vertical");
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + f, Player.transform.position.z);
        }
    }

    void OnColliderEnter(Collider aCol)
    {
        if(aCol.tag.Equals("Money"))
        {
            Money++;
        }

        if(aCol.tag.Equals("BigMoney"))
        {
            for(int i = 0; i < 5; i++)
            {
                Money++;
            }
        }
    }
}


