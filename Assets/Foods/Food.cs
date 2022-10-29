using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Food")]
public class Food : ScriptableObject

{
    public int ID;
    public string Name;
    public Sprite Image;
    public int UnlockLevel;
    public float PreparationTime;
    public int QuantityCooked;
    public GameObject Prefab;
    public int Cost, Price;
}