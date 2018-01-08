using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontaly : ICommand {
    Character character;
    public MoveHorizontaly(Character character)
    {
        this.character = character;
    }

    public void Execute()
    {
        character.moveHorizontaly();
    }
}

