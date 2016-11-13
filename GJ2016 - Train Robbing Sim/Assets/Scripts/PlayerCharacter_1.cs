using UnityEngine;

public class PlayerCharacter_1 : MonoBehaviour
{
    public GameObject Player;
    public AudioSource Source;
    public int Health;
    public int Money;
    private bool InputEnabled = true;
    //private Animator animator;

    // Use this for initialization
    private void Start()
    {
        Health = 100;
        Money = 0;
        Player.transform.position = new Vector3(-5, 0, -2);
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
        if (Health <= 0)
        {
            Destroy(gameObject);
        }

        /*
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (vertical > 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 0);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 1);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 3);
        }
        */

        if (Player.transform.position.x >= 7 &&
            Player.transform.position.y < .75f &&
            Player.transform.position.y > -.75f)
        {
            InputEnabled = false;
            if (Player.transform.position.x < 13.75f)
            {
                Player.transform.position = new Vector3(Player.transform.position.x + 0.1f, Player.transform.position.y, Player.transform.position.z);
            }
            else
            {
                Player.transform.position = new Vector3(-6.5f, Player.transform.position.y, Player.transform.position.z);
                InputEnabled = true;
            }
        }
    }

    private void CheckInput()
    {
        if (InputEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire3"))
            {
                print("Punchy punchy");
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                float f = Input.GetAxis("Horizontal");
                Player.transform.position = new Vector3(Player.transform.position.x + f / 10, Player.transform.position.y, Player.transform.position.z);
                if (Player.transform.position.x <= -8.25f)
                {
                    Player.transform.position = new Vector3(-8.25f, Player.transform.position.y, Player.transform.position.z);
                }
                else if (Player.transform.position.x >= 8.25f)
                {
                    Player.transform.position = new Vector3(8.25f, Player.transform.position.y, Player.transform.position.z);
                }
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                float f = Input.GetAxis("Vertical");
                Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + f / 10, Player.transform.position.z);
                if (Player.transform.position.y <= -3.5f)
                {
                    Player.transform.position = new Vector3(Player.transform.position.x, -3.5f, Player.transform.position.z);
                }
                else if (Player.transform.position.y >= 3.5f)
                {
                    Player.transform.position = new Vector3(Player.transform.position.x, 3.5f, Player.transform.position.z);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D aCol)
    {
        print("Colliding!");
        print(aCol.gameObject.tag.ToString());
        if (aCol.gameObject.tag.Equals("Money"))
        {
            Money++;
            Source.Play();
            Destroy(aCol.gameObject);
        }

        if (aCol.gameObject.tag.Equals("BigMoney"))
        {
            Destroy(aCol.gameObject);

            for (int i = 0; i < 5; i++)
            {
                Money++;
                Source.Play();
            }
        }

        if (aCol.gameObject.tag.Equals("Enemy"))
        {
            Health = 0;
        }
    }
}