using UnityEngine;

public class movFondo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float velocidad;
    public GameObject conejo;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (conejo.GetComponent<SpriteRenderer>().flipX)
        {
            meshRenderer.material.mainTextureOffset += new Vector2(velocidad * Time.deltaTime* -1,0);
        }
       else
        {
            meshRenderer.material.mainTextureOffset += new Vector2(velocidad * Time.deltaTime,0);
        }
    }
}
