using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public GameObject Tool;
    private float timer = 0;
    public float lowestPoint = -7;
    public float highestPoint = 7;
    public float spawnRate = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

    }
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnObject();
        }
    }

    // Update is called once per frame
    void spawnObject()
    {

        Instantiate(Tool, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 0),transform.rotation);

    }
}
