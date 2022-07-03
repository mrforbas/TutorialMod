using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TutorialMod.Content.Items
{
    public class MyModdedItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Set item name and tooltip
            DisplayName.SetDefault("My modded item");
            Tooltip.SetDefault("This is a modded item.");

            // Journey mode
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            // Item propreties
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(gold: 1, silver: 50);
        }

        public override void AddRecipes()
        {
            CreateRecipe(10)
                .AddIngredient(ItemID.DirtBlock, 10) // Ingredients required
                .AddTile(TileID.WorkBenches) // Tile required
                .Register();
        }
    }
}
