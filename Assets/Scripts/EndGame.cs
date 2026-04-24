using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Hello world");
            Application.Quit();
        }
        
    }
}
