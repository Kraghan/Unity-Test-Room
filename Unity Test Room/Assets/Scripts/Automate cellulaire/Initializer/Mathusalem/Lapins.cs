using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapins : Initializer
{

    public override uint[] Initialize(uint[] array, Vector2 dimension)
    {
        Vector2 milieu = new Vector2((uint)(dimension.x / 2), (uint)(dimension.y / 2));

        array[(uint)milieu.x + (uint)(milieu.y - 2) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + 2 + (uint)(milieu.y - 2) * (uint)dimension.x] = 1;

        array[(uint)milieu.x - 4 + (uint)(milieu.y - 1) * (uint)dimension.x] = 1;
        array[(uint)milieu.x - 2 + (uint)(milieu.y - 1) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + 1 + (uint)(milieu.y - 1) * (uint)dimension.x] = 1;

        array[(uint)milieu.x - 3 + (uint)(milieu.y) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + 1 + (uint)(milieu.y) * (uint)dimension.x] = 1;

        array[(uint)milieu.x - 3 + (uint)(milieu.y + 1) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + 3 + (uint)(milieu.y + 1) * (uint)dimension.x] = 1;

        return array;

    }
}
