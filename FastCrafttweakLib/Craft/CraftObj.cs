namespace FastCrafttweakLib.Craft
{
    class CraftObj
    {
        public string Name { get; set; }
        public string Texture { get; set; }
        public string[] Inputs { get; set; }
        public string Output { get; set; }

        public CraftObj(string Name, string Texture, string[] Inputs, string Output)
        {
            this.Name = Name;
            this.Texture = Texture;
            this.Inputs = Inputs;
            this.Output = Output;
        }
    }
}
