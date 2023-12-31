using Godot;
using System;

public partial class enemy : CharacterBody2D
{
	
	Godot.RichTextLabel Coins;
	
	Godot.CharacterBody2D target;
	
	Vector2 speed = new Vector2(120,120);
	Vector2 spawnradius = new Vector2(1000,1000);
	Vector2 move_spawnradius = new Vector2(500,250);
	
	private void _on_area_2d_area_entered(Area2D area)
	{
		Coins = this.GetParent().GetNode<Godot.RichTextLabel>("Show_Coins");
		
		Coins.Text = (Int32.Parse(Coins.Text) + 1).ToString();
		
		this.QueueFree();
	}
	
	
	public override void _Ready(){
		float rngnumber = Convert.ToSingle(GD.RandRange(-3.14, 3.14));
		
		this.Position = new Vector2(Mathf.Cos(rngnumber), Mathf.Sin(rngnumber)) * spawnradius + move_spawnradius;
		
		target = GetParent().GetNode<Godot.CharacterBody2D>("Player");
	}
	
	public override void _PhysicsProcess(double delta)
	{
		Velocity = this.Position.DirectionTo(target.Position) * speed;
		MoveAndSlide();
	}
}



