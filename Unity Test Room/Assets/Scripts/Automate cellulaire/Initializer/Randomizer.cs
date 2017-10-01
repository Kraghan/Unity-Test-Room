using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : Initializer
{

    public float treshold;

    public override uint[] Initialize(uint[] array, Vector2 dimension)
    {
        for (uint i = 0; i < array.Length; ++i)
        {
            if (Random.Range(0.0f, 100.0f) < treshold)
                array[i] = 1;
        }

        return array;
    }
}
