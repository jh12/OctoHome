namespace OctoHome.Shared.DTOs.Hue
{
    public class HueLight
    {
        public string Id { get; }
        public HueLightState State { get; set; }
        public string Type { get; }
        public string Name { get; }
        public string ModelId { get; }
        public string ProductId { get; }
        public string SwConfigId { get; }
        public string UniqueId { get; }
        public string LuminaireUniqueId { get; }
        public string ManufacturerName { get; }
        public string SoftwareVersion { get; }

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