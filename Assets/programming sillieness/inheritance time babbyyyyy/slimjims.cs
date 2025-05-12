using AG3566;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
namespace AG3566
{
    public class partying : MonoBehaviour
    {
        Dummies slimmest = new Dummies();
        shimmyjims killem = new shimmyjims();
        void Start() 
        {
            if (gameObject.tag == "slimjims")
            { slimmest = GameObject.FindGameObjectWithTag("slimjims").GetComponent<Dummies>(); }

            else { killem = GameObject.FindGameObjectWithTag("shimmies").GetComponent<shimmyjims>(); }
            
            //killem = GameObject.FindGameObjectWithTag("shimmies").GetComponent<shimmyjims>();

        }
        void Update() 
        {
            if (gameObject.tag == "slimjims")
                { slimmest.partyTime(); }
            else { killem.partyTime(); }
           
        
        }
    }

}