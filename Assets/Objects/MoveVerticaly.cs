using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticaly : ICommand {
    Character character;
    public MoveVerticaly(Character character)
    {
        this.character = character;
    }

    public void Execute()
    {
        character.moveVerticaly();
    }
}

