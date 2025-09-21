using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Collection", menuName = "ScriptableObjects/Collection")]
public class CollectionSO : ScriptableObject
{
    public List<CollectionData> collections = new List<CollectionData>();
    
    public CollectionData GetDataByCollectionID(int ownerID)
    {
        foreach (CollectionData data in collections)
        {
            if (data.ownerID == ownerID)
            {
                return data;
            }
        }
        return null;
    }
    
    public int GetIndexByOwnerID(int ownerID)
    {
        for (int i = 0; i < collections.Count; i++)
        {
            if (collections[i].ownerID == ownerID)
            {
                return i;
            }
        }

        return -1;
    }
}

[System.Serializable]
public class CollectionData
{
    public int id;
    public string name;
    public int ownerID;
    public bool rescue = false;
}