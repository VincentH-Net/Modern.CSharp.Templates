﻿namespace $namespace$;

partial class ViewNamePage
{
    enum Row { Header, Body }

    public void BuildUI() => Content (
        Grid (
            Rows (
                (Row.Header, Auto), 
                (Row.Body  , Star)
            ),

            NavigationBar("ViewName")
               .Grid_Row(Row.Header),

            TextBlock()
               .Assign(out messageTextBlock)
               .Grid_Row(Row.Body) .Center()
        )
    );
}
