using DotNetCoach.Episode1;

List<object> mixOfObjects = new()
{
    true,
    87,
    "Hello World",
    176.0,
    new {X = 42, Y = 87}
};

foreach (dynamic o in mixOfObjects)
{
    // Perform distinct handling depending upon the runtime type of o
    ObjectHandler.Handle(o); // <-- runtime decides!
}
