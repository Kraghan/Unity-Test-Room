﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentominoR : Initializer
{

    public override uint[] Initialize(uint[] array, Vector2 dimension)
    {
        Vector2 milieu = new Vector2((uint)(dimension.x/2), (uint)(dimension.y/2));
        array[(uint)milieu.x + (uint)(milieu.y - 1) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + (uint)milieu.y * (uint)dimension.x] = 1;
        array[(uint)milieu.x + 1 + (uint)milieu.y * (uint)dimension.x] = 1;
        array[(uint)milieu.x - 1 + (uint)(milieu.y + 1) * (uint)dimension.x] = 1;
        array[(uint)milieu.x + (uint)(milieu.y + 1) * (uint)dimension.x] = 1;

        return array;

    }
}
