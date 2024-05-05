using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeWith(List<NormalItem.eNormalType> types, List<int> weights)
    {
        for (int i = 0; i < weights.Count; i++)
        {
            weights[i] = -weights[i];
        }

        int weightSum = weights.Sum();

        int index = 0;
        int lastIndex = types.Count - 1;
        while (index < lastIndex)
        {
            if (Random.Range(weightSum, 0) < weights[index])
            {
                return types[index];
            }
 
            weightSum -= weights[index++];
        }
 
        return types[index];
    }
}
