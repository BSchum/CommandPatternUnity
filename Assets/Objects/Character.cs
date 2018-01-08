using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public float speed;
    public string name;
    public int force;
    public int hp;

    MovementScripts movementManager;

    public Character(float speed, string name, int force, int hp)
    {
        this.speed = speed;
        this.name = name;
        this.force = force;
        this.hp = hp;
        movementManager = new MovementScripts();
    }

    public void SetAttribute(float speed, string name, int force, int hp)
    {
        this.speed = speed;
        this.name = name;
        this.force = force;
        this.hp = hp;
        movementManager = new MovementScripts();
    }

    public void moveHorizontaly()
    {
        movementManager.MoveHorizontaly(this.speed, Input.GetAxis("Horizontal"), this.transform);
    }
    public void moveVerticaly()
    {
        movementManager.MoveVerticaly(this.speed, Input.GetAxis("Vertical"), this.transform);
    }

}
