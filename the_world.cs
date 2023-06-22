using Godot;
using System;

public partial class the_world : Node2D
{
	dynamic preloadenemy;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		preloadenemy = GD.Load<PackedScene>("res://enemy.tscn");
	}
	
	private void _on_timer_timeout()
	{
		SpawnEnemy();
	}
	
	
	void SpawnEnemy(){
		var enemy = preloadenemy.Instantiate();
		AddChild(enemy);
	}
	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}



