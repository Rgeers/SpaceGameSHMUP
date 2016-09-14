using UnityEngine;
using System.Collections;

abstract class Base : MonoBehaviour {
    protected Stats stats;

    protected abstract void Attack() {
        
    }

    protected abstract void Move() {

    }

    protected virtual void TakeDamage() {

    }

    protected virtual void OnDeath() {

    }

}

private class Stats {
    protected int hitPoints, movementSpeed, damage;

    public Stats(int hitPoints, int movementSpeed, int damage) {
        this.hitPoints = hitPoints;
        this.movementSpeed = movementSpeed;
        this.damage = damage;
    }

}
