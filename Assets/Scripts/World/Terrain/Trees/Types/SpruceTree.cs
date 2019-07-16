﻿
public class SpruceTree : TreeType
{
    public SpruceTree()
    {
        height = 8;

        woodBlock = 13;
        leafBlock = 14;

        leafModel = new int[] 
        {
            0, 1, 0,
            0, 0, 0,

            1, 0, 0,
            0, 0, 1,
            0, 0, -1,
            -1, 0, 0,

            1, -2, 0,
            0, -2, 1,
            0, -2, -1,
            -1, -2, 0,
            -1, -2, -1,
            -1, -2, 1,
            1, -2, -1,
            1, -2, 1,

            2, -2, 0,
            0, -2, 2,
            0, -2, -2,
            -2, -2, 0,

            1, -4, 0,
            0, -4, 1,
            0, -4, -1,
            -1, -4, 0,
            -1, -4, -1,
            -1, -4, 1,
            1, -4, -1,
            1, -4, 1,

            1, -5, 0,
            0, -5, 1,
            0, -5, -1,
            -1, -5, 0,
            -1, -5, -1,
            -1, -5, 1,
            1, -5, -1,
            1, -5, 1,

            2, -5, 0,
            0, -5, 2,
            0, -5, -2,
            -2, -5, 0,

        };

    }
}
