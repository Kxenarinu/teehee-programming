using AG3566;
using UnityEngine;
namespace AG3566
{
    public class slimjims : Dummies
    {
        slimjims killinit = new slimjims();
        void Start()
        {
            
        }
        void Update() 
        { 
         killinit.gameObject.SetActive(true);
            killinit.partyTime();
        }
    }

}