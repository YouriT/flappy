using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
            return;
        }

        Spawn();
    }

    private void Spawn()
    {
        var transform1 = transform;
        var position = transform1.position;
        var lowestPoint = position.y - heightOffset;
        var highestPoint = position.y + heightOffset;
        
        Instantiate(
            pipe,
            new Vector3(position.x, Random.Range(lowestPoint, highestPoint), position.z),
            transform1.rotation);
        timer = 0;
    }
}
