using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isFirstManager;

        void Awake(){
            DontDestroyOnLoad(gameObject);
            GameManager[] gms = FindObjectsOfType<GameManager>();
        for (int i=0; i<gms.Length; i++){
            if (gms[i].isFirstManager == true)
                return;
        }
        isFirstManager = true;
        for ( int i=0; i< gms.Length; i++) {
            if( gms[i].isFirstManager== false){
                Destroy(gms[i]);
            }
        }
    }
}
