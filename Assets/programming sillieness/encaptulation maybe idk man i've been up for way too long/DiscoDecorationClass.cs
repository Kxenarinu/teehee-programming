using UnityEngine;
namespace AG3566
{
    public class DiscoDecorationClass : MonoBehaviour
    {

        public MeshRenderer Renderer;
        private float startDelay = 1.0f;
        private float repeat = 2.0f;

        public void DiscoTime() //method ???
        {
           InvokeRepeating("changeColor", startDelay, repeat);
            InvokeRepeating("changeSize", startDelay, repeat / 3);
        }

        private  void changeColor() //method??
        {
            Material material = Renderer.material;

            material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        }
        private void changeSize() //method ??????

        {
            transform.localScale = Vector3.one * Random.Range(0.1f, 2.5f);

        }
    }

}