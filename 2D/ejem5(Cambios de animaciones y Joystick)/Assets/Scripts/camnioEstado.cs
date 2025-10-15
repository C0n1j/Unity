using UnityEngine;
using UnityEngine.Rendering;

public class cambioEstado : MonoBehaviour
{
    private Animator animatorTrump;
    public int velocidad;
    public bl_Joystick joystick;
    
    void Start()
    {
        // el componente (en este caso Trump) guardamos el componente Animator
        animatorTrump = this.GetComponent<Animator>();
    }

    
    void Update()
    {

        // Version para moverse con las flechas
            //float movimientoHorizontal = Input.GetAxis("Horizontal"); //capturqamos el eje horizontal
            //float movimientoVertical = Input.GetAxis("Vertical"); //capturamos el eje vertical

        // Version para moverse con el joystick (UJoystick)
            float movimientoHorizontal = joystick.Horizontal; //capturqamos el eje horizontal
            float movimientoVertical = joystick.Vertical; //capturamos el eje vertical


        // Determinamos la dirección y actualizamos la animación
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animatorTrump.SetInteger("posicion", 2);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animatorTrump.SetInteger("posicion", 8);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animatorTrump.SetInteger("posicion", 4);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animatorTrump.SetInteger("posicion", 6);
        }

        // otra forma de hacerlo con el joystick
        if (movimientoVertical < -0.1f) // Movimiento hacia abajo
        {
            animatorTrump.SetInteger("posicion", 2);
        }
        else if (movimientoVertical > 0.1f) // Movimiento hacia arriba
        {
            animatorTrump.SetInteger("posicion", 8);
        }
        else if (movimientoHorizontal < -0.1f) // Movimiento hacia la izquierda
        {
            animatorTrump.SetInteger("posicion", 4);
        }
        else if (movimientoHorizontal > 0.1f) // Movimiento hacia la derecha
        {
            animatorTrump.SetInteger("posicion", 6);
        }
      
                                // Vector 3 -> (x,y,z)
        this.transform.Translate(new Vector3(movimientoHorizontal, movimientoVertical, 0) * velocidad * Time.deltaTime);  // vector de movimiento

    }
}
