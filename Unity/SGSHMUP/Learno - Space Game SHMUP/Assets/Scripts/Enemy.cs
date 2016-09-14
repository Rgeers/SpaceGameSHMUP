using UnityEngine;
using System.Collections;

public class Enemy : Base {
    private int ownHitPoints, ownMovementSpeed, ownDamage;
    void Start() {
        stats = new Stats(ownHitPoints, ownMovementSpeed, ownDamage);
    }

}
