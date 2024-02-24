using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	// This is really the only blurb of code you need to implement a Unity singleton
	private static DontDestroy _Instance;
	

       void Awake()
    {

        if(_Instance != null){
Destroy(this.gameObject);
        }
        else{

            _Instance = this ;
        DontDestroyOnLoad(this.gameObject);

        }
    }
}
