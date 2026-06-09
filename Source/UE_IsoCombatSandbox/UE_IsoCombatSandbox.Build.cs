// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE_IsoCombatSandbox : ModuleRules
{
	public UE_IsoCombatSandbox(ReadOnlyTargetRules Target) : base(Target)
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
			"UE_IsoCombatSandbox",
			"UE_IsoCombatSandbox/Variant_Platforming",
			"UE_IsoCombatSandbox/Variant_Platforming/Animation",
			"UE_IsoCombatSandbox/Variant_Combat",
			"UE_IsoCombatSandbox/Variant_Combat/AI",
			"UE_IsoCombatSandbox/Variant_Combat/Animation",
			"UE_IsoCombatSandbox/Variant_Combat/Gameplay",
			"UE_IsoCombatSandbox/Variant_Combat/Interfaces",
			"UE_IsoCombatSandbox/Variant_Combat/UI",
			"UE_IsoCombatSandbox/Variant_SideScrolling",
			"UE_IsoCombatSandbox/Variant_SideScrolling/AI",
			"UE_IsoCombatSandbox/Variant_SideScrolling/Gameplay",
			"UE_IsoCombatSandbox/Variant_SideScrolling/Interfaces",
			"UE_IsoCombatSandbox/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
