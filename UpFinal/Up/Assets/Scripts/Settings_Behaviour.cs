using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings_Behaviour : MonoBehaviour {

	public void ChangeSettings()
    {
        SceneManager.LoadScene(5);
    }
}
