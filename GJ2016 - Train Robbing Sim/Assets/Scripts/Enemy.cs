using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;

    // Use this for initialization
    private void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}