using UnityEngine;
namespace AG3566 
{ 

public class changerscript : MonoBehaviour
{
    public MeshRenderer Rende;
    private float startDela = 2.0f;
    private float repea = 1.0f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        InvokeRepeating("changeColor", startDela, repea);

    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    void changeColor()
    {
        Material material = Rende.material;

        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    
}
}