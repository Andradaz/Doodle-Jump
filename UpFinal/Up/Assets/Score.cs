using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform Character;
    public Text scoreText;

    // Update is called once per frame
    void Update () {
        scoreText.text = Character.position.y.ToString("0");
        GlobalVariables.Finnal = scoreText.text;
    }
}
