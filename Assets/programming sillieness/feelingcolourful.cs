using Unity.FPS.Game;
using UnityEngine;

namespace AG3566 { 
public class Mineenemy : MonoBehaviour
{

    public MeshRenderer Renderer;
    private float startDelay = 2.0f;
    private float repeat = 1.0f;

    

    void Start()
    {
        transform.position = new Vector3(3, 6, 1);
        transform.localScale = Vector3.one * 2.5f;
            InvokeRepeating("changeColor", startDelay, repeat);
            InvokeRepeating("changeSize", startDelay, repeat/3);

        }

    void Update()
    {
            transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    void changeColor()
    {
        Material ma = Renderer.material;

        ma.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    void changeSize()
        
        {
            transform.localScale = Vector3.one * Random.Range(0.1f, 2.5f);

        }
}



}
