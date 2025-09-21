using System;
using UnityEngine;
using UnityEngine.Events;

public class CollectionManager : MonoBehaviour
{
    public static CollectionManager Instance;
    
    [SerializeField] private CollectionSO collectionSO;
    public UnityAction OnChangeCollection;

    private void OnEnable()
    {
        OnChangeCollection += OnChangedCollection;
    }

    private void OnDisable()
    {
        OnChangeCollection -= OnChangedCollection;
    }

    private void OnChangedCollection()
    {
        Debug.Log("OnChangedCollection");
    }
    
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<CollectionManager>();
        }
    }

    public void ChangeCollection(int index)
    {
        collectionSO.collections[index].rescue = true;
        OnChangeCollection?.Invoke();
    }
}