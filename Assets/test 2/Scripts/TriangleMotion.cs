using UnityEngine;

public class TriangleMotion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D Triangle)
    {
        if (Triangle.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
