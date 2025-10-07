using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float upperBound = 25.0f;
    public float lowerBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        if(transform.position.z < lowerBound || transform.position.z > upperBound) Destroy(gameObject);
    }
}
