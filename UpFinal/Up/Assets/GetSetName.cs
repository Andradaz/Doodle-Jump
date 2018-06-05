using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GetSetName : MonoBehaviour {

    public InputField Name;
    
    public void setName()
    {
        GlobalVariables.Name = Name.text;
        SceneManager.LoadScene(7);
    }
    
    
}
