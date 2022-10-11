using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaEnemigo1 : MonoBehaviour
{
public float hit = 1;
public float speed = 3.0f; //variable velocidad bala
public Transform PuntoDisparo;
//la bala toca a otro enemigo

void Start()
    {
       
        //si la bala no colisiona, no importa, porque se destruye en dos segundos
    }
void Update(){ //solo necesitamos que se ejecute cuando se acciona
    transform.position += transform.right * Time.deltaTime * speed; //el objeto(bala) inicia hacia a la izquierda porque el enemigo aparece mirando hacia ahi
}
   private void OnCollisionEnter2D (Collision2D collision) {
        var player = collision.collider.GetComponent<PlayerControler>();
                //Invoke("Destruir_",2);
       if (player) {
            player.TakeHit (hit);
            Destroy(gameObject);
        }
    }
   /*      void Destruir_()
    {
        Destroy(this.gameObject); //destruye el objeto de este script(la bala)
    }
 */
}
    /*
    public float speed; //velocidad
    private Rigidbody2D m_rig; //cuerpo rigid
    public GameObject impacto;
        public float hit = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_rig = GetComponent<Rigidbody2D>(); 
        m_rig.AddForce(Vector2.right*speed,ForceMode2D.Impulse); //la bala tiene impulso hacia la derecha y le decimos que lo haga a x velocidad
        Invoke("Destruir_",2); //si la bala no colisiona, no importa, porque se destruye en dos segundos
    }
void Update()
{
    void Destruir_()
    {
        Destroy(this.gameObject); //destruye el objeto de este script(la bala)
    }


    
}
private void OnCollisionEnter2D(Collision2D collision)//chequea la colision
    {
        
      Instantiate(impacto, this.transform.position,this.transform.rotation); //instancia de impacto,previa a destruir la bala
       Destruir_();
       //Mako
               var player = collision.collider.GetComponent<PlayerControler>();
       if (player) {
            player.TakeHit (hit);
            Destroy(gameObject);
    }

} */
