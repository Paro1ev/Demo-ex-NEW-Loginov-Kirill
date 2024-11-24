var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


class Order
{
    public Order(int number, DateOnly startDate, string device, string problemType, string desciption, string client, string status)
    {
        Number = number;
        StartDate = startDate;
        Device = device;
        ProblemType = problemType;
        Desciption = desciption;
        Client = client;
        Status = status;
    }

    public int Number { get; set; }
    public DateOnly StartDate { get; set; }
    public string Device {  get; set; }
    public string ProblemType { get; set; }
    public string Desciption { get; set; }
    public string Client {  get; set; }
    public string Status { get; set; }
    public DateOnly? EndDate { get; set; } = null;
    public string? Master { get; set; } = "не назначен";
    public List<string> Comments { get; set; } = [];
}

record class UpdateOrderDTO(int Number, string? Status, string? Description, string? Master, string? Comment);