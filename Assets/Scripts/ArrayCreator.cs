using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCreator : MonoBehaviour
{
    private char[,] array = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' }, { 'I', 'J', 'K', 'L' } };
    private char[,] charArray = new char[3, 4];

    private void Awake()
    {
        for (int r = 0; r < charArray.GetLength(0); r++)
        {
            for (int c = 0; c < charArray.GetLength(1); c++)
            {
                var code = 65 + 4 * r + c;
                charArray[r, c] = (char)code;
            }
        }
    }
}
