using Godot;
using System;

public partial class sword : Sprite2D
{
	
	dynamic parent;
	
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
		parent.LookAt(GetGlobalMousePosition());
	}
}
