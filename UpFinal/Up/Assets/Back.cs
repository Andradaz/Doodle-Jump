using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Back : MonoBehaviour {
	public void GoBack()
    {
        SceneManager.LoadScene(1);
    }

}
