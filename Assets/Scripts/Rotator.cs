using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotationDirection = Vector3.one;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDirection * Time.deltaTime);
    }
}
