using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    public float velBala;
    public float hit = 1;

    public Transform PuntoDisparoEnemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right *velBala* Time.deltaTime;

    }

   private void OnCollisionEnter2D (Collision2D collision) {
        var player = collision.collider.GetComponent<PlayerControler>();
            //    Invoke("Destruir_",2);
       if (player) {
            player.TakeHit (hit);
            Destroy(gameObject);
        }
    }
/*         void Destruir_()
    {
        Destroy(this.gameObject); //destruye el objeto de este script(la bala)
    } */
}
