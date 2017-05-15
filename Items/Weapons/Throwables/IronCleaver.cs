using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Items.Weapons.Throwables
{
    public class IronCleaver : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Iron Cleaver";
            item.thrown = true;
            item.damage = 10;
            item.noMelee = true;
            item.width = 28;
            item.height = 30;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 23;
            item.rare = 1;
            item.reuseDelay = 20;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("IronCleaverProj");
            item.shootSpeed = 8f;
            item.useTurn = true;
            item.maxStack = 999;
            item.consumable = true;
            item.noUseGraphic = true;
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