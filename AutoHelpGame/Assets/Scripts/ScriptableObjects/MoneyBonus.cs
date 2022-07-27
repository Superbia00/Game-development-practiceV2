using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBonus", menuName = "Configs/Bonuses/MoneyBonus")]
public class MoneyBonus : Bonus
{
    [SerializeField]
    private int _bonusValue;
    public override string Desc => $"����� ������������� ������ � {_bonusValue}�";

    public override string ShortDesc => $"����� {_bonusValue}�";

    
}
