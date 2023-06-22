using Godot;
using System;

public partial class player : CharacterBody2D
{
	
	Vector2 Speed = new Vector2(130,130);
	
	
	private void _on_restart_button_button_down()
	{
		GetTree().Paused = false;
		var this_world = (PackedScene)ResourceLoader.Load("res://the_world.tscn");
		GetTree().ChangeSceneToPacked(this_world);
	}
	
	
	
	
	private void _on_zombiechecker_area_entered(Area2D area)
	{
		GetTree().Paused = true;
		Godot.Button restart_button = this.GetNode<Godot.Button>("Restart_Button");
		restart_button.GlobalPosition = new Vector2(500,250);
		restart_button.Visible = true;
		restart_button.Disabled = false;
	}
	
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





