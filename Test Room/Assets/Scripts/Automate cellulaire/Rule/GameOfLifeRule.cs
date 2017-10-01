using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLifeRule : Rule
{
    // 1 : alive
    // 0 : dead

    public override uint[] Process(uint[] array, Vector2 dimension)
    {

        uint[] newArray = new uint[array.Length];
        for (uint i = 0; i < dimension.x; ++i)
        {
            for (uint j = 0; j < dimension.y; ++j)
            {
                uint neighbours = GetNeighbour(array, dimension, i,j);

                if (array[i + j * (uint)dimension.y] == 1 && neighbours != 2 && neighbours != 3)
                    newArray[i + j * (uint)dimension.y] = 0;
                else if (array[i + j * (uint)dimension.y] == 0 && neighbours == 3)
                    newArray[i + j * (uint)dimension.y] = 1;
                else
                    newArray[i + j * (uint)dimension.y] = array[i + j * (uint)dimension.y];
            }
        }

        return array;
    }
	
    private uint GetNeighbour(uint[] array, Vector2 dimension, uint x, uint y)
    {
        uint cpt = 0;
            if(x != 0)
            {
                if(y != 0)
                    cpt += array[(x - 1) + (y - 1) * (uint)dimension.y];

                cpt += array[(x - 1) + y * (uint)dimension.y];

                if (y != dimension.y - 1)
                    cpt += array[(x - 1) + (y + 1) * (uint)dimension.y];
            }

            if(x != (uint) (dimension.x - 1))
            {
                if (y != 0)
                    cpt += array[(x + 1) + (y - 1) * (uint)dimension.y];

                cpt += array[(x + 1) + y * (uint)dimension.y];

                if (y != dimension.y - 1)
                    cpt += array[(x + 1) + (y + 1) * (uint)dimension.y];
            }

            if (y != 0)
                cpt += array[x + (y - 1) * (uint)dimension.y];
            if (y != dimension.y - 1)
                cpt += array[x + (y + 1) * (uint)dimension.y];
            
        return cpt;
    }

}
