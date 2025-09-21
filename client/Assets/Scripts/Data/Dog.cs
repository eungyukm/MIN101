public class Dog
{
    public string Name;
    public float MiningSpeed;
    public float Efficiency;
    public bool HasGraduated;

    public Dog(string name, float miningSpeed, float efficiency)
    {
        Name = name;
        MiningSpeed = miningSpeed;
        Efficiency = efficiency;
        HasGraduated = false;
    }

    public float Mine()
    {
        return MiningSpeed * Efficiency;
    }
}