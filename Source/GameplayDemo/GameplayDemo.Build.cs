// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GameplayDemo : ModuleRules
{
	public GameplayDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GameplayDemo",
			"GameplayDemo/Variant_Platforming",
			"GameplayDemo/Variant_Platforming/Animation",
			"GameplayDemo/Variant_Combat",
			"GameplayDemo/Variant_Combat/AI",
			"GameplayDemo/Variant_Combat/Animation",
			"GameplayDemo/Variant_Combat/Gameplay",
			"GameplayDemo/Variant_Combat/Interfaces",
			"GameplayDemo/Variant_Combat/UI",
			"GameplayDemo/Variant_SideScrolling",
			"GameplayDemo/Variant_SideScrolling/AI",
			"GameplayDemo/Variant_SideScrolling/Gameplay",
			"GameplayDemo/Variant_SideScrolling/Interfaces",
			"GameplayDemo/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
