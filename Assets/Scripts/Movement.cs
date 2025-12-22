using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float moveHamster = -5;
    public float moveSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(moveSpeed * moveHamster * Time.deltaTime, 0, 0);
        }
       
    }
}
