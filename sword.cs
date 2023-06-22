using Godot;
using System;

public partial class sword : Sprite2D
{
	dynamic parent;
	float angletomouse = 0f;
	
	Vector2 velocity = new Vector2(0,0);
	Vector2 sword_radius = new Vector2(20, 25);
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if (this.GetParent() == null){
			return;
		}
		
		parent = this.GetParent();
	}
	
	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		angletomouse = parent.GetAngleTo(GetGlobalMousePosition());
		
		this.Position = new Vector2(Mathf.Cos(angletomouse), Mathf.Sin(angletomouse)) * sword_radius;
		
		
		this.LookAt(GetGlobalMousePosition());
		
		
		
	}
}
