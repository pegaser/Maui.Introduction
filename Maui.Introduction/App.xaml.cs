﻿using Microsoft.Maui.Controls;

namespace Maui.Introduction;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
