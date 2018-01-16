using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
      
        if(SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex + 1)
        {
            SceneManager.LoadScene("Scena1");
        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

    }
}
   
