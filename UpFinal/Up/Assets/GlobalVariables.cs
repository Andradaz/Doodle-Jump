using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public static class GlobalVariables{
    public static string Finnal;
    public static List<int> ScoreBoard = new List<int>();
    public static int numberOfScores = 0;
    public static string ListaScoruri;
    public static string TreesScoruri;
    public static string Name;

    //Lists
    public class Nod
    {
        public Nod urm;
        public object val;
        public string nume;
        public string time;
    }

    public class LinkedList
    {
        public Nod cap;
        private Nod curent;
        public int nr;
        public int n;

        public LinkedList()
        {
            cap = new Nod();
            curent = cap;
        }

        public void AdaugaInceput(string nume, string time, object data)
        {
            Nod newNod = new Nod();
            newNod.val = data;
            newNod.nume = nume;
            newNod.urm = cap;
            newNod.time = time;
            cap = newNod;
            curent = newNod;
            nr++;
        }

        public void AdaugaFinal(string nume, string time, object data)
        {
            if (curent == null)
            {
                AdaugaInceput(nume, time, data);
            }
            else
            {
                Nod newNod = new Nod();
                newNod.val = data;
                newNod.nume = nume;
                newNod.time = time;
                curent.urm = newNod;
                curent = newNod;
                nr++;
            }

        }

        public void StergeLista()
        {
            cap = null;
            curent = null;
        }

        public void CreareText()
        {
            Nod aux = cap;
            while(aux != null)
            {
                ListaScoruri = ListaScoruri + aux.nume + "     " + aux.time + "     " + aux.val + "\n";
                aux = aux.urm;
            }
            //ListaScoruri = ListaScoruri + "\n" + System.DateTime.Now.Hour.ToString() + " : " + System.DateTime.Now.Minute.ToString() + "         " + curent.nume + "         " + curent.val;
            

        }

    
    }

    public static LinkedList Scores = new LinkedList();
     


    //Trees
    public class Node
    {
        public int val;
        public string nume;
        public string time;
        public Node left;
        public Node right;
    }


    public class Tree
    {
        public Node inserare(Node root, string nume, string time, int data)
        {
            if(root == null)
            {
                root = new Node();
                root.val = data;
                root.nume = nume;
                root.time = time;
            }
            else if(data > root.val)
            {
                root.left = inserare(root.left, nume, time, data);
            }
            else
            {
                root.right = inserare(root.right, nume, time, data);
            }
            return root;
        }

        public void parcurgere(Node root)
        {
            if(root == null)
            {
                return;
            }
            parcurgere(root.left);
            TreesScoruri = TreesScoruri + root.nume + " " + root.time + " " + root.val + "\n";
            parcurgere(root.right);
  

        }

        public void StergeTree(Node root)
        {
           root = null;
        }
    }

    public static Tree ArboreBinar = new Tree();
}


