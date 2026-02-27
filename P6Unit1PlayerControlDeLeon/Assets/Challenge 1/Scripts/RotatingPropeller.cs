
using UnityEngine;

public class RotatingPropeller : MonoBehaviour
{
    //Making sure you adjust the speed of your propeller
    public float rotationSpeed = 1000f;

    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}      
