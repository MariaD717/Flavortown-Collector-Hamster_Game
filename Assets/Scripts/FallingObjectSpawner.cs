using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingObjectSpawner : MonoBehaviour
{
    public GameObject Food;
    private float timer = 0;
    public float lowestPoint = -7;
    public float highestPoint = 7;
    public float spawnRate1 = 2;
    public float spawnRate2 = 3;
    public float gameTimer = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }
    void Update()
    {
        
        if (timer < spawnRate1)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnObject();
        }
        if (timer < spawnRate2)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnObject();
        }
        if (timer < gameTimer)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Time.timeScale = 0f;

        }
    }

    // Update is called once per frame
    void spawnObject()
    {

        Instantiate(Food, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 0),transform.rotation);
        
    }
    void gameOver()
    {
        Time.timeScale = 0f;
    }
}
