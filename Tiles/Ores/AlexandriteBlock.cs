using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Tiles.Ores
{
    public class AlexandriteBlock : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Alexandrite Ore";
            item.width = 20;
            item.height = 18;
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AlexandriteBlockSheet");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}