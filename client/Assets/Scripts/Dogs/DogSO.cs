using UnityEngine;

[CreateAssetMenu(fileName = "Dog", menuName = "ScriptableObjects/Dog")]
public class DogSO : ScriptableObject
{
    public int id;
    public string name;
    public int age;
    public int maxLife;
    
    public enum DogSize { Small, Medium, Large}
    public DogSize size;

    public int GetSpeed()
    {
        switch (size)
        {
            case DogSize.Small:
                return 1 * GetGrade();
            case DogSize.Medium:
                return 3 * GetGrade();
            case DogSize.Large:
                return 5 * GetGrade();
        }
        return 0;
    }
    
    public enum DogGrade {Normal, Rare, Epic, Legendary}
    public DogGrade grade;

    public int GetGrade()
    {
        switch (grade)
        {
            case DogGrade.Normal:
                return 1;
            case DogGrade.Rare:
                return 2;
            case DogGrade.Epic:
                return 3;
            case DogGrade.Legendary:
                return 4;
        }
        return 0;
    }
    
    public enum StaminalLevel {Low, Medium, High}
    public StaminalLevel staminal;
    
    public enum SpeedLevel {Low, Medium, High}
    public SpeedLevel speed;
}

public class DogData
{
    public int id;
    public string name;
    public int age;
    public int maxLife;
    
    public enum DogSize { Small, Medium, Large}
    public DogSize size;

    public int GetSpeed()
    {
        switch (size)
        {
            case DogSize.Small:
                return 1 * GetGrade();
            case DogSize.Medium:
                return 3 * GetGrade();
            case DogSize.Large:
                return 5 * GetGrade();
        }
        return 0;
    }
    
    public enum DogGrade {Normal, Rare, Epic, Legendary}
    public DogGrade grade;

    public int GetGrade()
    {
        switch (grade)
        {
            case DogGrade.Normal:
                return 1;
            case DogGrade.Rare:
                return 2;
            case DogGrade.Epic:
                return 3;
            case DogGrade.Legendary:
                return 4;
        }
        return 0;
    }
    
    public enum StaminalLevel {Low, Medium, High}
    public StaminalLevel staminal;
    
    public enum SpeedLevel {Low, Medium, High}
    public SpeedLevel speed;
}