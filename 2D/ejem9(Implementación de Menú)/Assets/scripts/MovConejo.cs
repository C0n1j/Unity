using UnityEngine;

public class MovConejo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 4f; // Velocidad de movimiento del enemigo

    void Start()
    {
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 

        if (horizontal < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (horizontal > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        this.transform.Translate(new Vector2 (horizontal,0) * speed * Time.deltaTime);
    }
}
