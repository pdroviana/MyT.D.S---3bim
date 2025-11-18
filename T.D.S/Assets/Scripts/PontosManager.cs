using System;
using TMPro;
using UnityEngine;

public class PontosManager : MonoBehaviour
{
    public static int pontos = 0;

    public static void Addpontos(int amount)
    {
        pontos += amount;
    }
}
    