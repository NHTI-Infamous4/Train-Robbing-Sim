using UnityEngine;

public class PlayerCharacter_1 : MonoBehaviour
{
    public GameObject Player;
    public int Health;
    public int Money;
    private Animator animator;
    

    // Use this for initialization
    private void Start()
    {
        Health = 100;
        Money = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
        if (Health <= 0)
        {
            Destroy(gameObject);
        }

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
            Player.transform.position = new Vector3(Player.transform.position.x + f / 10, Player.transform.position.y, Player.transform.position.z);
            if (Player.transform.position.x <= -8.25f)
            {
                Player.transform.position = new Vector3( -8.25f, Player.transform.position.y,Player.transform.position.z);
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnColliderEnter(Collider aCol)
    {
        if (aCol.tag.Equals("Money"))
        {
            Money++;
        }

        if (aCol.tag.Equals("BigMoney"))
        {
            for (int i = 0; i < 5; i++)
            {
                Money++;
            }
        }
    }
}