using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class EndGame : MonoBehaviour {

    // Use this for initialization

    //StreamWriter sw = File.AppendText("D:\\Proiecte\\Unity\\Meow\\Up\\Bazadedate.txt");
    StreamWriter sw = File.AppendText("D:\\Bazadedate.txt");
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            sw.WriteLine(GlobalVariables.Name);
            sw.WriteLine(System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString());
            sw.WriteLine(GlobalVariables.Finnal);
            sw.Close();
            SceneManager.LoadScene(8);
        }
    }
}
