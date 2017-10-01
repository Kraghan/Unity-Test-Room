using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessInitializer : Initializer {

    public override uint[] Initialize(uint[] array, Vector2 dimension)
    {
        for (uint i = 0; i < array.Length; ++i)
        {
            if ((i & 1) == 0)
                array[i] = 1;
        }

        return array;
    }

} 