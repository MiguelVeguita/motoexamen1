using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroles : MonoBehaviour
{
    private Rigidbody _rig;
    public float hozi, verty;
    public float raydistancia;
    public bool detetor;
    public LayerMask condi;
    public float salto;
    public int saltorestantes;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = 20;
        _rig = GetComponent<Rigidbody>();
    
        
    }

    // Update is called once per frame
    void Update()
    {
       // detetor = Physics.Raycast(transform.position, new Vector3(0, -5, 0), raydistancia, condi);
       // Debug.DrawRay(transform.position, new Vector3(0, -5, 0) * raydistancia, Color.green);
        hozi = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W))
        {
            verty = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            verty = -1;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (detetor==true)
            {
                _rig.velocity = new Vector3(_rig.velocity.x, salto,_rig.velocity.z);
                
            }
          //  saltorestantes = 1;
        }
       /* if (Input.GetKeyDown(KeyCode.Space) && saltorestantes > 0)
        {
            _rig.velocity = new Vector2(_rig.velocity.x, salto);
            saltorestantes = saltorestantes - 1;
            if (saltorestantes == 0)
            {
                _rig.velocity = new Vector2(_rig.velocity.x, salto);
            }
        }*/

    }
    private void FixedUpdate()
    {
        _rig.velocity = new Vector3(hozi * 5, _rig.velocity.y, verty * 5);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag== "suelo")
        {
            detetor = true;
        }
        if (collision.gameObject.tag == "ganar")
        {
            SceneManager.LoadScene("ganar");
        }
        if (collision.gameObject.tag == "enemi")
        {
            vida = vida - 10;
            if (vida <= 0)
            {
                SceneManager.LoadScene("perder");
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag=="suelo")
        {
            detetor = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="enemi")
        {
            vida = vida - 10;
            if (vida <= 0)
            {
                SceneManager.LoadScene("perder");
            }
        }
      
    }

}
