using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class ImportCards {

    //public string[] Basic = new string[10000];
    //public string[] Common = new string[10000];
    //public string[] Uncommon = new string[10000];
    //public string[] Rare = new string[10000];
    //public string[] Epic = new string[10000];

    public string name;
    public Cards cards;

    public bool LoadCards()
    {
        cards = new Cards();

        if (File.Exists(Application.dataPath + "\\Lootboxes\\cards.json"))
        {
            string jsonFile = File.ReadAllText(Application.dataPath + "\\Lootboxes\\cards.json");
            cards = JsonUtility.FromJson<Cards>(jsonFile);
            return true;
        }
        return false;
    }
}

[System.Serializable]
public struct Cards
{
    public CardDetails[] Basic;
    public CardDetails[] Common;
    public CardDetails[] Uncommon;
    public CardDetails[] Rare;
    public CardDetails[] Epic;
}

[System.Serializable]
public struct CardDetails
{
    public int id;
    public string cardArt;
}
//public class Cards
//{
//    public int[] Basic = new int[50];
//    public int[] Common = new int[50];
//    public int[] Uncommon = new int[50];
//    public int[] Rare = new int[50];
//    public int[] Epic = new int[50];
//}
