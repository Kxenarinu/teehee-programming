using System;
using Unity.FPS.Game;
using UnityEngine;

namespace AG3566
{
    public class Mineenemy : MonoBehaviour
    {

        DiscoDecorationClass DiscoBall;
       
       

        void Start()
        {
            DiscoBall = GameObject.FindGameObjectWithTag("DiscoTag").GetComponent<DiscoDecorationClass>();
           

            transform.position = new Vector3(3, 6, 1);
            transform.localScale = Vector3.one * 2.5f;

           
            DiscoBall.DiscoTime();

        }

        void Update()
        {
            transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        }

    }
}
