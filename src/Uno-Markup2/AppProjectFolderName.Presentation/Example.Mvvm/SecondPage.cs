﻿namespace $namespacePrefix$.Presentation.CsMarkup2Example;

partial class SecondPage
{
    public void BuildUI() => Content (
        Grid (
            NavigationBar("Second Page")
               .MainCommand(
                   AppBarButton() .Icon(Icon("Icons/back"))
               ),

            TextBlock()
               .Bind(vm?.Entity.Name)
               .Center()
        )
    );
}
