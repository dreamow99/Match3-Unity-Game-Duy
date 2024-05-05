using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skin/skinConfig")]
public class NormalItemSkin : ScriptableObject
{
    public Sprite typeOneSkin;
    public Sprite typeTwoSkin;
    public Sprite typeThreeSkin;
    public Sprite typeFourSkin;
    public Sprite typeFiveSkin;
    public Sprite typeSixSkin;
    public Sprite typeSevenSkin;

    public Sprite GetSkin(NormalItem.eNormalType ItemType)
    {
        switch (ItemType)
        {
            case NormalItem.eNormalType.TYPE_ONE:
                return typeOneSkin;
            case NormalItem.eNormalType.TYPE_TWO:
                return typeTwoSkin;
            case NormalItem.eNormalType.TYPE_THREE:
                return typeThreeSkin;
            case NormalItem.eNormalType.TYPE_FOUR:
                return typeFourSkin;
            case NormalItem.eNormalType.TYPE_FIVE:
                return typeFiveSkin;
            case NormalItem.eNormalType.TYPE_SIX:
                return typeSixSkin;
            case NormalItem.eNormalType.TYPE_SEVEN:
                return typeSevenSkin;
        }

        return null;
    }
}
