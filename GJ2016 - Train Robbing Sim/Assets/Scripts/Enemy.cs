using UnityEngine;

public class Enemy : MonoBehaviour
{
    private enum direction
    {
        Right,
        Down,
        Left,
        Up
    };

    public int Health;
    public GameObject Player;
    private float Speed = 0.05f;
    private direction PatrolStatus = direction.Right;
    private float time = 0;
    private float detectionTime = 2f;

    // Use this for initialization
    private void Start()
    {
        Health = 100;
        gameObject.transform.position = new Vector3(0, 2, -2);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        switch (PatrolStatus)
        {
            case direction.Right:
                {
                    if (gameObject.transform.position.x >= 6)
                    {
                        gameObject.transform.position = new Vector3(6, 2, -2);
                        PatrolStatus = direction.Down;
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3(gameObject.transform.position.x + Speed, gameObject.transform.position.y, gameObject.transform.position.z);
                    }
                    break;
                }
            case direction.Down:
                {
                    if (gameObject.transform.position.y <= -2)
                    {
                        gameObject.transform.position = new Vector3(6, -2, -2);
                        PatrolStatus = direction.Left;
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - Speed, gameObject.transform.position.z);
                    }
                    break;
                }
            case direction.Left:
                {
                    if (gameObject.transform.position.x <= 0)
                    {
                        gameObject.transform.position = new Vector3(0, -2, -2);
                        PatrolStatus = direction.Up;
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3(gameObject.transform.position.x - Speed, gameObject.transform.position.y, gameObject.transform.position.z);
                    }
                    break;
                }
            case direction.Up:
                {
                    if (gameObject.transform.position.y >= 2)
                    {
                        gameObject.transform.position = new Vector3(0, 2, -2);
                        PatrolStatus = direction.Right;
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Speed, gameObject.transform.position.z);
                    }
                    break;
                }
        }
        if (Player)
        {
            Vector3 toPlayer = transform.TransformDirection((Player.transform.position - gameObject.transform.position) / (Player.transform.position - gameObject.transform.position).magnitude);
            Debug.DrawRay(gameObject.transform.position, toPlayer);
            if (Physics2D.Raycast(transform.position, toPlayer, Mathf.Infinity, 1 << 8).collider.gameObject.tag == "Player")
            {
                print("I see you!");
                if (time != 0 && Time.time >= time + detectionTime)
                {
                    Destroy(Player);
                }
                else if (time == 0)
                {
                    print("Setting Time");
                    time = Time.time;
                }
            }
            else time = 0;
        }
    }

    private void FixedUpdate()
    {
    }

    public void SpeedUp()
    {
        Speed += 0.1f;
    }
}