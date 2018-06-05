using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoreboard_Behaviour : MonoBehaviour {

	public void SeeScoreboard()
    {
        SceneManager.LoadScene(2);
    }
}
