using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoStateRule : Rule {

    protected uint GetNeighbour(uint[] array, Vector2 dimension, uint x, uint y)
    {
        uint cpt = 0;
        if (x != 0)
        {
            if (y != 0)
                cpt += array[(x - 1) + (y - 1) * (uint)dimension.x];

            cpt += array[(x - 1) + y * (uint)dimension.x];

            if (y != (uint)dimension.y - 1)
                cpt += array[(x - 1) + (y + 1) * (uint)dimension.x];
        }

        if (x != (uint)(dimension.x - 1))
        {
            if (y != 0)
                cpt += array[(x + 1) + (y - 1) * (uint)dimension.x];

            cpt += array[(x + 1) + y * (uint)dimension.x];

            if (y != (uint)dimension.y - 1)
                cpt += array[(x + 1) + (y + 1) * (uint)dimension.x];
        }

        if (y != 0)
            cpt += array[x + (y - 1) * (uint)dimension.x];
        if (y != (uint)dimension.y - 1)
            cpt += array[x + (y + 1) * (uint)dimension.x];

        return cpt;
    }
}
