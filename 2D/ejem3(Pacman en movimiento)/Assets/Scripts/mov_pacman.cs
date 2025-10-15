using UnityEngine;

public class mov_pacman : MonoBehaviour
{
    public int velocidad = 8;
    public bl_Joystick joystick; // Referencia al joystick


    void Update()
    {
        // Movimiento con teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Si hay joystick asignado, usamos sus valores
        if (joystick != null)
        {
            float joystickH = joystick.Horizontal;
            float joystickV = joystick.Vertical;

            // Combinamos ambos inputs (el que tenga mayor valor se usa)
            if (Mathf.Abs(joystickH) > Mathf.Abs(horizontal))
                horizontal = joystickH;
            if (Mathf.Abs(joystickV) > Mathf.Abs(vertical))
                vertical = joystickV;
        }

        // Aplicamos el movimiento
        Vector3 movimiento = new Vector3(horizontal, vertical, 0);
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);

        // Rotación con teclado
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        // Rotación con joystick (cuando hay movimiento significativo)
        if (joystick != null)
        {
            if (joystick.Vertical > 0.1f) // Arriba
            {
                transform.eulerAngles = new Vector3(0f, 0f, 90f);
            }
            else if (joystick.Vertical < -0.1f) // Abajo
            {
                transform.eulerAngles = new Vector3(0f, 0f, -90f);
            }
            else if (joystick.Horizontal < -0.1f) // Izquierda
            {
                transform.eulerAngles = new Vector3(0f, -180f, 0f);
            }
            else if (joystick.Horizontal > 0.1f) // Derecha
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
    }
}