using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public void changeToScene(int value){
    	Debug.Log("Hello Its working");
    	Application.LoadLevel(value);
    }
}
