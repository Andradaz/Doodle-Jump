using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {

    public Text FinnalScore;
    public int n;
    private void LateUpdate()
    {
        FinnalScore.text = GlobalVariables.Finnal;

    }

}
