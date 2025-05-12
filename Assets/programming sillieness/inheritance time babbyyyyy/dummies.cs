using UnityEngine;
namespace AG3566
{
    public class Dummies : MonoBehaviour
    {
        //This is a Smooth version of rotation between 0 and the given Angle at Y.
        // Use this for initialization
        protected float speed = 0.5f;
        protected float RotAngleZ = 90;
        public virtual void partyTime() 
        {
            float rZ = Mathf.SmoothStep(0, RotAngleZ, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, 0, rZ);
        }
       
    
    }

    
}