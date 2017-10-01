using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDisplayer : MonoBehaviour
{
    public float spriteSize;
    public Vector2 dimension;
    public Vector2 offset;
    private uint[] array;
    public GameObject cell;
    private GameObject[] cells;
    public GameObject container;

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
        cells = new GameObject[(uint)dimension.x * (uint)dimension.y];

        for (uint i = 0; i < array.Length; ++i)
            array[i] = 0;

        array = initializer.Initialize(array, dimension);

        for (uint i = 0; i < dimension.x; ++i)
        {
            for (uint j = 0; j < dimension.y; ++j)
            {
                cells[i + j * (uint)dimension.x] = Instantiate(cell);
                cells[i + j * (uint)dimension.x].transform.position = new Vector3(offset.x + i * spriteSize, offset.y + j * spriteSize);
                if (array[i + j * (uint)dimension.x] == 0)
                    cells[i + j * (uint)dimension.x].SetActive(false);
                cells[i + j * (uint) dimension.x].transform.parent = container.transform;
            }
        }

        deltaTime = 0.0;

	}

    private void DisplayArray(uint[] array, Vector2 dimension)
    {
        String s = "[";
        for (uint i = 0; i < dimension.y; ++i)
        {
            for (uint j = 0; j < dimension.x; ++j)
            {
                s += array[j + i * (uint)dimension.x] + ",";
            }
            s += "\n";
        }
        Debug.Log(s + "]");

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
                    if (array[x + y * (uint)dimension.x] == 1)
                    {
                        cells[x + y * (uint)dimension.x].SetActive(true);
                    }

                    if (array[x + y * (uint)dimension.x] == 0)
                    {
                        cells[x + y * (uint)dimension.x].SetActive(false);
                    }
                }
            }
            deltaTime -= updateTime;
        }
	}
}
