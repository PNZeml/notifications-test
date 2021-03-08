namespace NotificationsTest.Application.Services.Dtos {
    internal class EmployeeDto {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public override string ToString() => $"{LastName} {FirstName} {MiddleName}";
    }
}
