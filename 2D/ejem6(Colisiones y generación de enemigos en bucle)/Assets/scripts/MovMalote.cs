using UnityEngine;

public class MovMalote : MonoBehaviour
{
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("MatarMalote", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 3);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
    public void MatarMalote()
    {
        Destroy(this.gameObject);
    }
}
