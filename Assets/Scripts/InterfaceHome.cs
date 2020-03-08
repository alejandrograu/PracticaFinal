using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceHome : MonoBehaviour
{
	
	public void GoStartGame(){
		SceneManager.LoadScene("StartGame");
	}
	public void GoInstruccions(){
		SceneManager.LoadScene("Instruccions");
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
