using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void EquipWeapon();
    void UpgradeWeapon();
    void Attack();
    void MoveToLeft(int parentPos);
    void MoveToRight(int parentPos);
}
