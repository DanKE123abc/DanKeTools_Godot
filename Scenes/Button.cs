using Godot;
using System;
using System.Security.Policy;
using DanKeTools.Event;
using DanKeTools;
using DanKeTools.Scene;

public class Button : Godot.Button
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	
	public override void _Ready()
	{
		
	}
	
	private void _on_Button_pressed()
	{
		EventCenter.Instance().EventTrigger("Hello");
		SceneManager.Instance().LoadScene("res://Scenes/Change.tscn",Test);
	}

	void Test()
	{
		GD.Print("Change");
	}
	
}



