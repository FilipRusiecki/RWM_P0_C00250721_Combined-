using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
    public static int[] modulo(int[] xs)
    {
        int numOne = xs[0];
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i] % numOne;
        }
        return result;
    }

    public static int run(int x)
    {
        return x;
    }

    public static int[] runtotal(int[] xs)
    {
        int[] result = new int[xs.Length];
        int[] newArray = new int[xs.Length];
        int sum = 0;

        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = run(xs[i]);
            sum += result[i];
            newArray[i] = sum;
        }
        return newArray;
    }
}