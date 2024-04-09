using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public int vell;
    public int xnega, xposi;
    private Rigidbody _ene;
    // Start is called before the first frame update
    void Start()
    {
        vell = 5;
        _ene = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= xnega)
        {
            vell = 5;
        }
        else if(this.transform.position.x >= xposi)
        {
            vell = -5;


        }
    }
    private void FixedUpdate()
    {
        _ene.velocity = new Vector3(1 * vell, _ene.velocity.y, _ene.velocity.z);
    }
}
