using System;

public class LinkedLists
{

    public class Nod
    {
        public Nod Next;
        public object val;
    }

    public class List
    {
        private Nod cap;
        private Nod curent;
        public int nr;
    }

    public List List ()
    {
        cap = new Nod();
        curent = head;
    }

    public void AdaugaLaFinal(object data)
    {
        Nod newNod = new Nod();
        newNod.val = data;
        curent.Next = newNod;
        curent = newNod;
        nr++;
    }

    public void AdaugaLaInceput(object data)
    {
        Nod newNod = new Nod() { val = data };
        newNod.Next = cap.Next;//new node will have reference of head's next reference
        cap.Next = newNod;//and now head will refer to new node
        nr++;
    }

    public void StergeDeLaInceput()
    {
        if (nr > 0)
        {
            cap.Next = cap.Next.Next;
            nr--;
        }
        else
        {
            Console.WriteLine("Nu exista element in lista");
        }
    }

    public void Afisare()
    {
        //Traverse from head
        Console.Write("Cap ->");
        Nod aux = head;
        while (aux.Next != null)
        {
            aux = aux.Next;
            Console.Write(aux.val);
            Console.Write("->");
        }
        Console.Write("NULL");
    }

}

class Program
{
    static void Main(string[] args)
    {
        List Scores = new List();
        Scores.Afisare();
        Console.WriteLine();

        Scores.AdaugaLaFinal(12);
        Scores.AdaugaLaFinal(13);
        Scores.Afisare();
        Console.WriteLine();

        Console.ReadKey();
    }
}
