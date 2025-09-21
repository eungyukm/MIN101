using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICollectionButton : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Button button;
    
    private CollectionData collectionData;
    
    public void SetData(CollectionData collectionData)
    {
        this.collectionData = collectionData;
        
        SetName(this.collectionData.name);
        SetButton();
    }

    private void SetName(string name)
    {
        text.text = name;
    }

    private void SetButton()
    {
        button.interactable = collectionData.rescue;
    }
}