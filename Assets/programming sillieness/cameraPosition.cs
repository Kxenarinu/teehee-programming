using UnityEngine;

public class cameraPosition : MonoBehaviour
{
    public Transform cameraPositiontype;

    // Update is called once per frame
    private void Update()
    {
        transform.position = cameraPositiontype.position;   
    }
}
