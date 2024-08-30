<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616412/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T224767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to create a custom DocumentManager with a custom View and a custom Document

This example demonstrates how to create a custom [DocumentManager](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.Docking2010.DocumentManager). Once you place this component onto a form, you can switch (convert) the current View to `WidgetView` using a smart tag menu. When you create new documents at design time or runtime, custom documents will be created. For demonstration purposes, the example adds a new custom property to the custom `Document` class. 

![Create a custom DocumentManager with a custom View and a custom Document](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-custom-documentmanager-with-a-custom-view-and-a-custom-document-t224767/14.2.5%2B/media/winforms-document-manager.png)

```csharp
[ToolboxItem(true)]
public class CustomDocumentManager : DocumentManager {
    public CustomDocumentManager() { }
    public CustomDocumentManager(IContainer container)
        : base(container) {

    }
    protected override void RegisterViews() {
        base.RegisterViews();
        RegisterView<CustomWidgetViewRegistrator>(ViewType.Widget);
    }
    public override BaseView CreateView(ViewType type) {
        if (type == ViewType.Widget) return new CustomWidgetView(Container);
        return base.CreateView(type);
    }
}
```


## Documentation

* [Application UI Manager](https://docs.devexpress.com/WindowsForms/11359/controls-and-libraries/application-ui-manager)
* [Getting Started](https://docs.devexpress.com/WindowsForms/402857/controls-and-libraries/application-ui-manager/get-started)
* [Create Custom Document Actions](https://docs.devexpress.com/WindowsForms/15686/controls-and-libraries/application-ui-manager/examples/how-to-create-custom-document-actions)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-create-custom-document-manager&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-create-custom-document-manager&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
