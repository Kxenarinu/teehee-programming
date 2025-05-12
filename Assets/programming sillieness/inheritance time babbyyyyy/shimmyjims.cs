using AG3566;
using UnityEngine;
namespace AG3566 
{

    public class shimmyjims : Dummies
    {
        shimmyjims killem = new shimmyjims();
        public override void partyTime()
        {
            float rZ = Mathf.SmoothStep(0, RotAngleZ, Mathf.PingPong(Time.time * speed, 1));
            transform.rotation = Quaternion.Euler(0, rZ, 0);
        }
        

    }


}

