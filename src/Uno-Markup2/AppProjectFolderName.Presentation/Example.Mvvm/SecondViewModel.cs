namespace $namespacePrefix$.Presentation.Example;

public partial class SecondViewModel(Entity entity) : BaseViewModel
{
    [ObservableProperty] public partial Entity Entity { get; set; } = entity;
}

public record Entity(string Name);
