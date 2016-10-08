namespace UnrealBuildTool.Rules
{
	public class VolumetricShader : ModuleRules
	{
		public VolumetricShader(TargetInfo Target)
        {
            PrivateIncludePaths.AddRange(
                new string[] {
					"VolumetricShader/Private"                    
                }
                );

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "RenderCore",
                    "ShaderCore",
                    "RHI"
				}
				);
		}
	}
}