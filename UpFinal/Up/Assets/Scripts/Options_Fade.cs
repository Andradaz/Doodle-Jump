using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options_Fade : MonoBehaviour {
        public Texture2D fadeOutTexture;
        public float fadeSpeed = 0.8f;

        private int drawDepth = -1000;
        private float alpha = 1.0f;
        private int fadeDir = -1; //in -1 out 1

        private void OnGUI()
        {
            //fade in out
            alpha += fadeDir * fadeSpeed * Time.deltaTime;

            //gUI  uses alpha values between 0 and 1 
            alpha = Mathf.Clamp01(alpha);

            //select color
            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
            GUI.depth = drawDepth;//render on top
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture); //fit the entire screen
        }


        public float BegInFade(int direction)
        {
            fadeDir = direction;
            return (fadeSpeed);
        }

        //called when a leel is loaded

        private void OnLevelWasLoaded()
        {
            alpha = 1;
            BegInFade(-1);
        }

}
