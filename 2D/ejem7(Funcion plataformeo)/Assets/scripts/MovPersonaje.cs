using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public int velocidad;
    private bool saltando = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        if (movHorizontal != 0)
        {
            this.transform.Translate(new Vector2(movHorizontal, 0) * Time.deltaTime * velocidad);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !saltando )
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2) * 5, ForceMode2D.Impulse);
            saltando = true;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            saltando = false;
            Debug.Log("colison con el suelo");
        }
    }
}
