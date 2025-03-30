using System;
using System.Collections.Generic;

class Program
{
    //Approach: To find the intersection, we’ll loop through one set and check if each element exists 
    // in the other set.

    //set1 = {1, 2, 3, 4, 5}
    //set2 = {2, 3}
    static HashSet<int> Interseccion(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1.Count > set2.Count) 
            (set1, set2) = (set2, set1); 

        HashSet<int> resultado = new HashSet<int>();
        foreach (int elem in set1)
        {
            if (set2.Contains(elem)) 
                resultado.Add(elem);
        }
        return resultado;
    }
    //O(N)


    //Approach: For the union, we simply add all elements from both sets into a new HashSet. 
    // Since sets don’t allow duplicates, we get the unique elements automatically.

    //set1 = {1, 2, 3, 4, 5}
    //set2 = {2, 3}
        static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> resultado = new HashSet<int>();

        foreach (int elem in set1) 
            resultado.Add(elem);

        foreach (int elem in set2) 
            resultado.Add(elem);

        return resultado;
    }
        //O(N)
}
