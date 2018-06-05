using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;

public class TreesText : MonoBehaviour
{
    public Text Text;
    void Start()
    {
        StreamReader sr = new StreamReader("D:\\Bazadedate.txt");

        GlobalVariables.Node root = null;

        string line1;
        string line2;
        string line3;
        int value;
        do
        {
            line1 = sr.ReadLine();
            line2 = sr.ReadLine();
            line3 = sr.ReadLine();
            value = Convert.ToInt32(line3);
            root = GlobalVariables.ArboreBinar.inserare(root, line1, line2, value);
        } while (line1 != null && line2 != null && value > -1);

        sr.Close();

        GlobalVariables.TreesScoruri = "";
        GlobalVariables.ArboreBinar.parcurgere(root);

        Text.text = GlobalVariables.TreesScoruri;

    }
}


