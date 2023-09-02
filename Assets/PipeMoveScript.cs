using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private const float XOutOfCamera = -26;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < XOutOfCamera)
        {
            Destroy(gameObject);
            Debug.Log("Pipe deleted");
            return;
        }
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
    }
}
