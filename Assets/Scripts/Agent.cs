using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour {

    /// <summary>
    /// Nome dell'agent.
    /// </summary>
    public string Name;
    public int Life;
    protected int InitialLife;
    public bool IsAlive = true;
    /// <summary>
    /// Velocità di movimento (maggiore è il valore, maggiore sarà la velocità di spostamento)
    /// </summary>
    public float MovementSpeed;
    /// <summary>
    /// Forza con coi avviene la spinta verso l'alto.
    /// </summary>
    public float JumpForce = 10;
    /// <summary>
    /// Identifica se il personaggio sta attualmenmte saltando (se true sta saltando).
    /// </summary>
    public bool IsJumping = false;
    public Rigidbody rigidbody = null;
    public float RespawnDelay;
    protected Vector3 respawnposition;

    private void Awake()
    {
        respawnposition = transform.position;
        InitialLife = Life;
    }
    /// <summary>
    /// Toglie una unità di salute a questo oggetto.
    /// </summary>
    public  void Damage(int DamageTaken)
    {
        Debug.Log("Ho subito un danno " + Name);
        Life = Life - DamageTaken;
        if (Life <= 0 )
        {
            IsAlive = false;
            if (gameObject.GetComponent<MeshRenderer>() != null)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
    public virtual void Kill()
    {
        Damage(Life);
    }

}
