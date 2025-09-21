using UnityEngine;
using System.Collections.Generic;
public class UICollection : UIPopup
{
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject gridLayoutRoot;
    
    [SerializeField] private CollectionSO collectionData;
    
    private List<GameObject> buttons = new List<GameObject>();

    private void OnEnable()
    {
        SetCollectionData();
    }
    
    public void SetCollectionData()
    {
        Debug.Log("OnActive called");
        for (int i = 0; i < collectionData.collections.Count; i++)
        {
            Debug.Log(collectionData.collections[i].name);
            buttons[i].GetComponent<UICollectionButton>().SetData(collectionData.collections[i]);
        }
    }

    private void Start()
    {
        CreateCollectionButtons();
    }

    private void CreateCollectionButtons()
    {
        foreach (var collection in collectionData.collections)
        {
            GameObject go = Instantiate(buttonPrefab, gridLayoutRoot.transform);
            buttons.Add(go);
            go.GetComponent<UICollectionButton>().SetData(collection);
        }
    }
}
