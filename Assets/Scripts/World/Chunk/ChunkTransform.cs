﻿using System;
using UnityEngine;

public class ChunkTransform
{
    public readonly int x, z;

    const int SIZE_X = 16, SIZE_Z = 16;
    const int SIZE_Y = 256;

    private const int POPULATION_OFFSET = 7;

    public ChunkTransform(int chunkX, int chunkZ)
    {
        this.x = chunkX;
        this.z = chunkZ;
    }

    public ChunkTransform(Vector2Int position)
    {
        this.x = position.x;
        this.z = position.y;
    }

    public ChunkTransform(float blockX, float blockZ)
    {     
        this.x = Mathf.FloorToInt(blockX / (float)SIZE_X);
        this.z = Mathf.FloorToInt(blockZ / (float)SIZE_Z);  
    }

    public bool PositionEquals(int x, int z)
    {
        return this.x == x && this.z == z;
    }

    public bool PopulatesBlock(int x, int z)
    {
        return PositionEquals
        (
            Mathf.FloorToInt((x - POPULATION_OFFSET) / (float)SIZE_X),
            Mathf.FloorToInt((z - POPULATION_OFFSET) / (float)SIZE_Z)
        );
    }

    public Vector2Int GetBlockCenter()
    {
        return new Vector2Int
        (
            x * SIZE_X + POPULATION_OFFSET,
            z * SIZE_Z + POPULATION_OFFSET
        );
    }

    public Vector3 GetBlockPosition()
    {
        return new Vector3(x * 16, 0f, z * 16);
    }

    public Vector2Int GetChunkPosition()
    {
        return new Vector2Int(x, z);
    }

    public new string ToString()
    {
        return "Chunk(" + x + ", " + z + ")";
    }

    internal ChunkTransform GetRight()
    {
        return new ChunkTransform(x + 1, z);
    }

    internal ChunkTransform GetLeft()
    {
        return new ChunkTransform(x - 1, z);
    }

    internal ChunkTransform GetFront()
    {
        return new ChunkTransform(x, z + 1);
    }

    internal ChunkTransform GetBack()
    {
        return new ChunkTransform(x, z - 1);
    }
}