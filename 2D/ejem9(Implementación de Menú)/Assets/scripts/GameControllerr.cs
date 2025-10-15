using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerr : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject camvas;
    
    void Start()
    {
        Time.timeScale = 1f; // Asegurarse de que el juego no esté pausado al iniciar
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            camvas.SetActive(!camvas.activeSelf);
            Time.timeScale = camvas.activeSelf ? 0 : 1; // Pausar o reanudar el juego con la tecla
        }
        /*if (Input.GetKeyDown(KeyCode.Return)) //Cambiar a la escena del juego al presionar Enter
        {
            SceneManager.LoadScene("Scene 2");*/
    }


    public void salir()
        {
            Application.Quit();
        }
        public void cambiarEscena()
        {
            Time.timeScale = camvas.activeSelf ? 0f : 1f; // Pausar o reanudar el juego con la tecla
            SceneManager.LoadScene("Scene 2");
        }
        

    }



