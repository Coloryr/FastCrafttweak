namespace FastCrafttweakLib.Craft.CraftList
{
    class CraftingTable : CraftObj
    {
        public CraftType Type { get; set; }
        public CraftingTable(string[] Inputs, string Output, CraftType type = CraftType.Shaped) : base("CraftingTable", "", Inputs, Output)
        {
            Type = type;
        }
    }
    enum CraftType
    {
        Shaped, Shapeless
    }
}
