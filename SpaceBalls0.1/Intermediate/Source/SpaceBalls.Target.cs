using UnrealBuildTool;

public class SpaceBallsTarget : TargetRules
{
	public SpaceBallsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SpaceBalls");
	}
}
