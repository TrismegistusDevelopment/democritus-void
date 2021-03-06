using System;

//TODO replace params with Dict<ShipItemType, int>
[Serializable]
public struct ShipParameters {
    public int Weapons;
    public int RearEngines;
    public int SideEngines;
    public int Shields;
    public int Generators;

    public ShipParameters(int weapons, int rearEngines, int sideEngines, int shields, int generators) {
        Weapons = weapons;
        RearEngines = rearEngines;
        SideEngines = sideEngines;
        Shields = shields;
        Generators = generators;
    }
}

public struct ShipAttributes {
    public readonly float RotationSpeed;
    public readonly float MovementSpeed;
    public readonly float MovementDamping;
    public readonly float MaximumSpeed;
    public readonly float BrakingForce;
    public readonly float Armor; //TODO add usages
    public float SmoothingAngle => RotationSpeed / 8;
    public ShipAttributes(float rotationSpeed, float movementSpeed, float movementDamping, float maximumSpeed, float brakingForce, float armor) {
        RotationSpeed = rotationSpeed;
        MovementSpeed = movementSpeed;
        MovementDamping = movementDamping;
        MaximumSpeed = maximumSpeed;
        BrakingForce = brakingForce;
        Armor = armor;
    }
}