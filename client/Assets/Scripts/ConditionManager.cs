using UnityEngine;

public class ConditionManager : MonoBehaviour
{
    public void GoToRun()
    {
        Debug.Log("Going to run");
    }

    private void Start()
    {
        Dog2 dog2 = new Dog2();
        dog2.Bark();
        dog2.Eat();
    }
}

class Animal
{
    public void Eat()
    {
        Debug.Log("먹는다");
    }
    
    // 상속 관계 내에서
    // protected void Eat()
    // {
    //     Debug.Log("먹는다");
    // }
    
    // 클래스 내에서
    // private void Eat()
    // {
    //     Debug.Log("먹는다");
    // }
}

class Dog2 : Animal
{
    public void Bark()
    {
        // 상속 관계
        // Eat();
        Debug.Log("짖는다");
    }
}