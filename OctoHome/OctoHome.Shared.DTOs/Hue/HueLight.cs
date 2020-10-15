namespace OctoHome.Shared.DTOs.Hue
{
    public class HueLight
    {
        public string Id { get; set; }
        public HueLightState State { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ModelId { get; set; }
        public string ProductId { get; set; }
        public string SwConfigId { get; set; }
        public string UniqueId { get; set; }
        public string LuminaireUniqueId { get; set; }
        public string ManufacturerName { get; set; }
        public string SoftwareVersion { get; set; }

        public HueLight()
        {
        }

        public HueLight(string id, HueLightState state, string type, string name, string modelId, string productId, string swConfigId, string uniqueId, string luminaireUniqueId, string manufacturerName, string softwareVersion)
        {
            Id = id;
            State = state;
            Type = type;
            Name = name;
            ModelId = modelId;
            ProductId = productId;
            SwConfigId = swConfigId;
            UniqueId = uniqueId;
            LuminaireUniqueId = luminaireUniqueId;
            ManufacturerName = manufacturerName;
            SoftwareVersion = softwareVersion;
        }
    }
}