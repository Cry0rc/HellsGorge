using Terraria.ModLoader;

namespace HellsGorge
{
	class CompleteOverhaul : Mod
	{
		public CompleteOverhaul()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
