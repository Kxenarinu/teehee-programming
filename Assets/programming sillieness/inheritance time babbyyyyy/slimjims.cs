using AG3566;
using UnityEngine;
namespace AG3566
{
    public class partying : MonoBehaviour
    {
        Dummies slimmest = new Dummies();
        //shimmyjims killem = new shimmyjims();
        void Start() 
        {
            slimmest = GameObject.FindGameObjectWithTag("slimjims").GetComponent<Dummies>();
            //killem = GameObject.FindGameObjectWithTag("shimmies").GetComponent<shimmyjims>();

        }
        void Update() 
        {

            slimmest.partyTime();
            //killem.partyTime();
        
        }
    }

}