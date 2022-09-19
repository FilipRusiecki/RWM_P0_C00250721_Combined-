using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
    public static int[] combinedFilter(int[] xs)
    {
        return ModuloFirst.modulo(RunningTotal.runtotal(xs));
    }
}