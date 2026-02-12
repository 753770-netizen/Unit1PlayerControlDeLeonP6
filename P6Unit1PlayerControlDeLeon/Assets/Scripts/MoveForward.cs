using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
