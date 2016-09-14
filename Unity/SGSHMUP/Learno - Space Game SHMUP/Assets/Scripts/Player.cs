using UnityEngine;
using System.Collections;

public class Player : Base {
    private int ownHitPoints, ownMovementSpeed, ownDamage;
	void Start() {
        stats = new Stats(ownHitPoints, ownMovementSpeed, ownDamage);
	}

}
