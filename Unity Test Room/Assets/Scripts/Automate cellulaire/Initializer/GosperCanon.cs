using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GosperCanon : Initializer {

    public override uint[] Initialize(uint[] array, Vector2 dimension)
    {
        // Emitter
        array[0 + 4 * (uint)dimension.x] = 1;
        array[0 + 3 * (uint)dimension.x] = 1;
        array[1 + 4 * (uint)dimension.x] = 1;
        array[1 + 3 * (uint)dimension.x] = 1;

        // Receiver
        array[(uint)34 + 6 * (uint)dimension.x] = 1;
        array[(uint)35 + 6 * (uint)dimension.x] = 1;
        array[(uint)34 + 5 * (uint)dimension.x] = 1;
        array[(uint)35 + 5 * (uint)dimension.x] = 1;

        // Bullet 1
        array[(uint)12 + 6 * (uint)dimension.x] = 1;
        array[(uint)13+6 * (uint)dimension.x] = 1;
        array[(uint)11+5 * (uint)dimension.x] = 1;
        array[(uint)15+5 * (uint)dimension.x] = 1;
        array[(uint)10+4 * (uint)dimension.x] = 1;
        array[(uint)16+4 * (uint)dimension.x] = 1;
        array[(uint)10+3 * (uint)dimension.x] = 1;
        array[(uint)14+3 * (uint)dimension.x] = 1;
        array[(uint)16+3 * (uint)dimension.x] = 1;
        array[(uint)17+3 * (uint)dimension.x] = 1;
        array[(uint)10+2 * (uint)dimension.x] = 1;
        array[(uint)16+2 * (uint)dimension.x] = 1;
        array[(uint)11+1 * (uint)dimension.x] = 1;
        array[(uint)15+1 * (uint)dimension.x] = 1;
        array[(uint)12+0 * (uint)dimension.x] = 1;
        array[(uint)13+0 * (uint)dimension.x] = 1;

        // Bullet 2
        array[(uint)24 + 8 * (uint)dimension.x] = 1;
        array[(uint)24 + 7 * (uint)dimension.x] = 1;
        array[(uint)22 + 7 * (uint)dimension.x] = 1;
        array[(uint)21 + 6 * (uint)dimension.x] = 1;
        array[(uint)20 + 6 * (uint)dimension.x] = 1;
        array[(uint)21 + 5 * (uint)dimension.x] = 1;
        array[(uint)20 + 5 * (uint)dimension.x] = 1;
        array[(uint)21 + 4 * (uint)dimension.x] = 1;
        array[(uint)20 + 4 * (uint)dimension.x] = 1;
        array[(uint)22 + 3 * (uint)dimension.x] = 1;
        array[(uint)24 + 3 * (uint)dimension.x] = 1;
        array[(uint)24 + 2 * (uint)dimension.x] = 1;

        return array;
    }
}
