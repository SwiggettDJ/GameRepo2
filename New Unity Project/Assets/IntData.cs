using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
    
    public void ReplaceValue(int num)
    {
        value = num;
    }
    
    public void ResetValue(int num)
    {
        value = 0;
    }
}
