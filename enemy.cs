using Godot;
using System;

public partial class enemy : CharacterBody2D
{
	
	Godot.CharacterBody2D target;
	
	Vector2 speed = new Vector2(120,120);
	
	public override void _Ready(){
		
		target = GetParent().GetNode<Godot.CharacterBody2D>("Player");
	}
	
	public override void _PhysicsProcess(double delta)
	{
		Velocity = this.Position.DirectionTo(target.Position) * speed;
		MoveAndSlide();
	}
}
