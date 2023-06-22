using Godot;
using System;

public partial class player : CharacterBody2D
{
	
	Vector2 Speed = new Vector2(100,100);
	
	void Movement(){
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed;
	}
	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Movement();
		MoveAndSlide();
	}
}
