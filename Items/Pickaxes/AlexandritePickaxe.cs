using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Items.Pickaxes
{
    public class AlexandritePickaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Alexandrite Pickaxe";
            item.damage = 21;
            item.melee = true;
            item.width = 42;
            item.height = 42;
            item.useTime = 10;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.pick = 10;
            item.knockBack = 6;
            item.value = 54;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
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