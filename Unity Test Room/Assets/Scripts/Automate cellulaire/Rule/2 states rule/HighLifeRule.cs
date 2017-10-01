using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLifeRule : TwoStateRule
{

    // 1 : alive
    // 0 : dead

    public override uint[] Process(uint[] array, Vector2 dimension)
    {

        uint[] newArray = new uint[(uint)dimension.x * (uint)dimension.y];
        for (uint i = 0; i < dimension.x; ++i)
        {
            for (uint j = 0; j < dimension.y; ++j)
            {
                uint neighbours = GetNeighbour(array, dimension, i, j);

                newArray[i + j * (uint)dimension.x] = 0;

                if (array[i + j * (uint)dimension.x] == 1)
                {
                    if (neighbours == 2 || neighbours == 3)
                    {
                        newArray[i + j * (uint)dimension.x] = 1;
                    }
                    else
                    {
                        newArray[i + j * (uint)dimension.x] = 0;
                    }
                }

                if (array[i + j * (uint)dimension.x] == 0 && neighbours == 3)
                {
                    newArray[i + j * (uint)dimension.x] = 1;
                }
            }
        }
        //DisplayArray(array, dimension);
        //DisplayArray(newArray, dimension);
        return newArray;
    }
}
