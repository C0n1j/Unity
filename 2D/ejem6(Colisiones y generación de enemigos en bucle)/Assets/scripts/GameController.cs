using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int contador = 0;
    public GameObject malote;


    void Start()
    {
        InvokeRepeating("CrearMalote", 3f, 3f);
    }

    private void CrearMalote()
    {
        Instantiate(malote, new Vector2(9.580971f, -3.210275f), transform.rotation);
    }
}