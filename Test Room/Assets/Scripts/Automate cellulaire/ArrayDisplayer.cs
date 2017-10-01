using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDisplayer : MonoBehaviour
{
    public float spriteSize;
    public Vector2 dimension;
    private uint[] array;

    public Initializer initializer;
    public Rule[] rules;

    public double updateTime;
    private double deltaTime;
    
    private uint GetArrayValue(uint x, uint y)
    {
        return array[x + y * (uint)dimension.y];
    }

    private void SetArrayValue(uint x, uint y, uint value)
    {
        array[x + y * (uint)dimension.y] = value;
    }

    private uint GetArrayValue(Vector2 pos)
    {
        return array[(uint)pos.x + (uint)pos.y * (uint)dimension.y];
    }

    private void SetArrayValue(Vector2 pos, uint value)
    {
        array[(uint)pos.x + (uint)pos.y * (uint)dimension.y] = value;
    }

    // Use this for initialization
    void Start ()
    {
        array = new uint[(uint)dimension.x * (uint)dimension.y];

        for (uint i = 0; i < array.Length; ++i)
            array[i] = 0;

        array = initializer.Initialize(array, dimension);

        deltaTime = 0.0;

	}
	
	// Update is called once per frame
	void Update ()
    {
        deltaTime += Time.deltaTime;
        if(deltaTime >= updateTime)
        {
            for (uint i = 0; i < rules.Length; ++i)
            {
                array = rules[i].Process(array, dimension);
            }

            for (uint x = 0; x < dimension.x; ++x)
            {
                for(uint y = 0; y < dimension.y; ++y)
                {
                    if(array[x + y * dimension.y])
                }
            }
        }
	}
}
