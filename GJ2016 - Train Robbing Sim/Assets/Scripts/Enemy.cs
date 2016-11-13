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
    private float Speed = 0.05f;
    private direction PatrolStatus = direction.Right;

    // Use this for initialization
    private void Start()
    {
        Health = 100;
        gameObject.transform.position = new Vector3(0, 2, -2);
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
    }

    public void SpeedUp()
    {
        Speed += 0.1f;
    }
}