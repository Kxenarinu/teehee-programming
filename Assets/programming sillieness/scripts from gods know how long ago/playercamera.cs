using UnityEngine;

namespace AG3566 
{ 
public class playercamera : MonoBehaviour
{
    //idea of the following camera code; if player moves mouse sideways when player and cam rotates at the x axis
    //if player moves mouse up and down then camera rotates on the y axis 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float sensitivityX;
    public float sensitivityY;

    public Transform orientation;

    float xRotation;
    float yRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //making the cursor locked to the centre and invisible (with below script)
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse input 
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivityY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //makes it so that you can't look up or down more than 90d

        //rotate can and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
}
