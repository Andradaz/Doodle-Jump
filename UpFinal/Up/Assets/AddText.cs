using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class AddText : MonoBehaviour {
   
    public Text noulText;
	void Start () {

        //StreamReader sr = new StreamReader("D:\\Proiecte\\Unity\\Meow\\Up\\Bazadedate.txt");
        StreamReader sr = new StreamReader("D:\\Bazadedate.txt");
        //GlobalVariables.Scores.CreareText();
        //GlobalVariables.ListaScoruri = "vata pe bat";

        GlobalVariables.Scores.StergeLista();

        string line1;
        string line2;
        string line3;
        do
        {
            line1 = sr.ReadLine();
            line2 = sr.ReadLine();
            line3 = sr.ReadLine();
            GlobalVariables.Scores.AdaugaFinal(line1, line2, line3);
        } while (line1 != null && line2 != null && line3 != null);

        sr.Close();
        GlobalVariables.ListaScoruri ="";
        GlobalVariables.Scores.CreareText();
        
        noulText.text = GlobalVariables.ListaScoruri;
 
       
	}

}
