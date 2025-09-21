using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/SaveOwnerSO")]
public class SaveOwnerSO : ScriptableObject
{
    [SerializeField] public List<Owenr> ownersData = new List<Owenr>();
}

// 직렬화를 해주는 역할을 합니다.
[System.Serializable]
public class Owenr
{
    public int id;
    public string name;
    public int dogId;
    public int price;
}