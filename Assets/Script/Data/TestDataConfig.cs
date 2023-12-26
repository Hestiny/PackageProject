using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TableDataConfig{

public class TestDataConfigClass
{
    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 1
    /// </summary>
    public readonly int aa;
    /// <summary>
    /// ar
    /// </summary>
    public readonly int[] ar;
    /// <summary>
    /// arr
    /// </summary>
    public readonly int[][] b;
    /// <summary>
    /// arrr
    /// </summary>
    public readonly int[][][] c;
    /// <summary>
    /// e
    /// </summary>
    public readonly PropType[][][] e;
    /// <summary>
    /// f
    /// </summary>
    public readonly float[,,] f;
    /// <summary>
    /// g
    /// </summary>
    public readonly float[,] g;
    /// <summary>
    /// h
    /// </summary>
    public readonly RewardStruct h;

    public TestDataConfigClass(int id, int aa, int[] ar, int[][] b, int[][][] c, PropType[][][] e, float[,,] f, float[,] g, RewardStruct h)
    {
        this.id = id;
        this.aa = aa;
        this.ar = ar;
        this.b = b;
        this.c = c;
        this.e = e;
        this.f = f;
        this.g = g;
        this.h = h;

    }
}
public class TestDataConfig
{
    public List<Dictionary<int, TestDataConfigClass>> GetCheckList()
    {
        return new List<Dictionary<int, TestDataConfigClass>>
        {
        TestDataConfig0.GetData(),
        };
    }
    
    public TestDataConfig()
    {
        Init();
    }

    private void Init()
    {
        mdata = new Dictionary<int, TestDataConfigClass>();
        var checkList = GetCheckList();
        int count = checkList.Count;
        for (int i = 0; i < count; i++)
        {
            foreach (var item in checkList[i])
                mdata.Add(item.Key, item.Value);
        }

        for (int i = count - 1; i >= 0; i--)
            checkList[i].Clear();

        checkList.Clear();
    }

    Dictionary<int, TestDataConfigClass> mdata;
    
    public Dictionary<int, TestDataConfigClass> data
    {
        get
        {
            if (null == mdata)
            {
                Init();
            }
            return mdata;
        }
    }

    public bool Check(int key)
    {
        return mdata?.ContainsKey(key) ?? GetCheckList().Any(item => item.ContainsKey(key));
    }

    public bool CheckAndGet(int key, out TestDataConfigClass config)
    {
        config = null;

        if (null != mdata)
            return mdata.TryGetValue(key, out config);
        foreach (var item in GetCheckList())
        {
            if (!item.TryGetValue(key, out var value)) continue;
            config = value;
            return true;
        }

        return false;
    }

    public TestDataConfigClass Get(int key)
    {
        if (null != mdata)
        {
            if (mdata.TryGetValue(key, out var value))
                return value;
        }
        else
        {
            foreach (var item in GetCheckList())
            {
                if (item.TryGetValue(key, out var value))
                    return value;
            }
        }

        return null;
    }
    
private class TestDataConfig0
{
    public static Dictionary<int, TestDataConfigClass> GetData()
    {
        return new Dictionary<int, TestDataConfigClass>()
        { 
        {1 , new TestDataConfigClass(1, 1, new int[]{1,2,3}, new int[][]{new int[]{1,2},new int[]{2,3}}, new int[][][]{new int[][]{new int[]{1,2},new int[]{4,5}},new int[][]{new int[]{3,4}},new int[][]{new int[]{6,7}}}, new PropType[][][]{new PropType[][]{new PropType[]{PropType.coin,PropType.ruby},new PropType[]{PropType.ruby,PropType.coin}},new PropType[][]{new PropType[]{PropType.coin,PropType.ruby}}}, new float[,,]{{{1f,2f},{4f,5f}},{{3f,4f},{6f,7f}}}, new float[,]{{1f,3f},{3f,4f}}, new RewardStruct (1,2,3f)) },

        };
	}
}
}
}