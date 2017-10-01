using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : MonoBehaviour
{
    public virtual uint[] Process(uint[] array, Vector2 dimension)
    {
        return array;
    }
}
