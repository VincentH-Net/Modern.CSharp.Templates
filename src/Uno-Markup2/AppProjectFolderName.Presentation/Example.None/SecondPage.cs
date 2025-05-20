namespace $namespacePrefix$.Presentation.Example;

partial class SecondPage
{
    public void BuildUI() => Content (
        Grid (
            NavigationBar("Second Page"),

            TextBlock()
               .Assign(out nameTextBlock)
               .Center(),

            ExampleFooter()
        )
    );
}
