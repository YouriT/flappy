using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public const int LayerTag = 3;
    public Rigidbody2D Body;
    public float flapStrength;
    public LogicManagerScript LogicManager;
    private bool isAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            Body.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isAlive = false;
        LogicManager.GameOver();
    }

    private void OnBecameInvisible()
    {
        isAlive = false;
        LogicManager.GameOver();
    }
}
