using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Agent {

    public Vector3 ArrivePoint;
    public bool GotoRight ;
    private void Start()
    {
        transform.position = respawnposition;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player"){
            other.GetComponent<BasePlayer>().Damage(2);
        }
    }

    private void Update()
    {
        Movement();
    }

    public override void Kill()
    {
        base.Kill();
        Destroy(this.gameObject);
    }
  
    public void Movement() {
        if (GotoRight==true)
        {
                transform.Translate(Vector3.right * Time.deltaTime);
            if(transform.position.x >= ArrivePoint.x)
                GotoRight= false;
        }
        else
        { 
                transform.Translate(Vector3.left * Time.deltaTime);
            if( transform.position.x <= respawnposition.x)
                GotoRight = true;
        }
    }
}

