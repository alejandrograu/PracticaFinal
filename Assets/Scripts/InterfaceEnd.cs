using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceEnd : MonoBehaviour
{
	
	public void GoHome(){
		SceneManager.LoadScene("Home");
		// Application.LoadLeve("NombreEscena");
	}
	public void GoExit(){
		Application.Quit();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
