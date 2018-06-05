using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateName : MonoBehaviour {
    public Text Nume;
	private void LateUpdate () {

        Nume.text = GlobalVariables.Name;
	}
}
