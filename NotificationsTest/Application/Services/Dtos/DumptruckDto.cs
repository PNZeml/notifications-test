namespace NotificationsTest.Application.Services.Dtos {
    internal class DumptruckDto {
        public string Id { get; set; }
        public string VehName { get; set; }
        public string Model { get; set; }
        
        public override string ToString() => $"{VehName} {Model} {Id}";
    }
}
