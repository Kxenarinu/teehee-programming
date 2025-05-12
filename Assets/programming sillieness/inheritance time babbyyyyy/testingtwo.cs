using AG3566;
using UnityEngine;
namespace AG3566
{ 
public class testingtwo : MonoBehaviour
{ 
    
        shimmyjims killem = new shimmyjims();
        void Start()
        {
            
            killem = GameObject.FindGameObjectWithTag("shimmies").GetComponent<shimmyjims>();

            //killem = GameObject.FindGameObjectWithTag("shimmies").GetComponent<shimmyjims>();

        }
        void Update()
        {
            killem.partyTime();
        }
    
}

}
