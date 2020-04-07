﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType {
        blue1,
        blue2,
        blue3,
        red1,
        red2,
        red3,
        green1,
        green2,
        green3,
        xp1,
        xp2,
        xp3,
    }

    public ItemType type;

    public Item (ItemType t) {
        type = t;
    }
    public Item (string s) {
        switch (s) {
            default:
            case "blue1":    type = ItemType.blue1; break;
            case "blue2":    type = ItemType.blue2; break;
            case "blue3":    type = ItemType.blue3; break;
            case "red1":     type = ItemType.red1; break;
            case "red2":     type = ItemType.red2; break;
            case "red3":     type = ItemType.red3; break;
            case "green1":   type = ItemType.green1; break;
            case "green2":   type = ItemType.green2; break;
            case "green3":   type = ItemType.green3; break;
            case "xp1":      type = ItemType.xp1; break;
            case "xp2":      type = ItemType.xp2; break;
            case "xp3":      type = ItemType.xp3; break;
        }
    }
    public void Consume() {
        switch (type) {
            default:
            case ItemType.blue1:    Slime.instance.hungerLvl += 5; Slime.instance.colour = 1; break;
            case ItemType.blue2:    Slime.instance.hungerLvl += 10; Slime.instance.colour = 1; break;
            case ItemType.blue3:    Slime.instance.hungerLvl += 20; Slime.instance.colour = 1; break;
            case ItemType.red1:     Slime.instance.hungerLvl += 5; Slime.instance.colour = 2; break;
            case ItemType.red2:     Slime.instance.hungerLvl += 10; Slime.instance.colour = 2; break;
            case ItemType.red3:     Slime.instance.hungerLvl += 20; Slime.instance.colour = 2; break;
            case ItemType.green1:   Slime.instance.hungerLvl += 5; Slime.instance.colour = 0; break;
            case ItemType.green2:   Slime.instance.hungerLvl += 10; Slime.instance.colour = 0; break;
            case ItemType.green3:   Slime.instance.hungerLvl += 20; Slime.instance.colour = 0; break;
            case ItemType.xp1:      Slime.instance.expLvl += 5; break;
            case ItemType.xp2:      Slime.instance.expLvl += 10; break;
            case ItemType.xp3:      Slime.instance.expLvl += 20; break;
        }
    }
    public Sprite GetSprite() {
        switch (type) {
            default:
            case ItemType.blue1:    return ItemAssets.instance.blue1Sprite;
            case ItemType.blue2:    return ItemAssets.instance.blue2Sprite;
            case ItemType.blue3:    return ItemAssets.instance.blue3Sprite;
            case ItemType.red1:     return ItemAssets.instance.red1Sprite;
            case ItemType.red2:     return ItemAssets.instance.red2Sprite;
            case ItemType.red3:     return ItemAssets.instance.red3Sprite;
            case ItemType.green1:   return ItemAssets.instance.green1Sprite;
            case ItemType.green2:   return ItemAssets.instance.green2Sprite;
            case ItemType.green3:   return ItemAssets.instance.green3Sprite;
            case ItemType.xp1:       return ItemAssets.instance.xp1Sprite;
            case ItemType.xp2:       return ItemAssets.instance.xp2Sprite;
            case ItemType.xp3:       return ItemAssets.instance.xp3Sprite;
        }
    }
    public int GetCost() {
        switch (type) {
            default:
            case ItemType.blue1:    return 1;
            case ItemType.blue2:    return 2;
            case ItemType.blue3:    return 3;
            case ItemType.red1:     return 1;
            case ItemType.red2:     return 2;
            case ItemType.red3:     return 3;
            case ItemType.green1:   return 1;
            case ItemType.green2:   return 2;
            case ItemType.green3:   return 3;
            case ItemType.xp1:       return 1;
            case ItemType.xp2:       return 2;
            case ItemType.xp3:       return 3;
        }
    }
    public string GetDescription() {
        switch (type) {
            default:
            case ItemType.blue1:    return "blue food level 1";
            case ItemType.blue2:    return "blue food level 2";
            case ItemType.blue3:    return "blue food level 3";
            case ItemType.red1:     return "red food level 1";
            case ItemType.red2:     return "red food level 2";
            case ItemType.red3:     return "red food level 3";
            case ItemType.green1:   return "green food level 1";
            case ItemType.green2:   return "green food level 2";
            case ItemType.green3:   return "green food level 3";
            case ItemType.xp1:       return "exp level 1";
            case ItemType.xp2:       return "exp level 2";
            case ItemType.xp3:       return "exp food level 3";
        }
    }
}
