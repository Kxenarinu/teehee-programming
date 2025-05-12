using UnityEngine;
namespace AG3566
{

public class testingone : MonoBehaviour
{
    //This is a Smooth version of rotation between 0 and the given Angle at Y.
    // Use this for initialization
    protected float speed = 0.5f;
    protected float RotAngleZ = 90;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rZ = Mathf.SmoothStep(0, RotAngleZ, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, rZ, 0);
    }
}
}
