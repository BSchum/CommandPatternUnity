using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    List<ICommand> commands;
    ICommand MoveH;
    ICommand MoveV;

    public Transform playerTransform;
    Character player;
    private void Start()
    {
        commands = new List<ICommand>();
        player = playerTransform.GetComponent<Character>();
        player.SetAttribute(2f, "Link", 10, 100);
        MoveH = new MoveHorizontaly(player);
        MoveV = new MoveVerticaly(player);
    }

    private void Update()
    {
        HandleInput();
    }

    public void StoreAndExecute(ICommand command)
    {
        commands.Add(command);
        command.Execute();
    }
    
    public void HandleInput()
    {
        if (Input.GetButton("Horizontal"))
        {
            StoreAndExecute(MoveH);
        }
        if (Input.GetButton("Vertical"))
        {
            StoreAndExecute(MoveV);
        }
    }

}
