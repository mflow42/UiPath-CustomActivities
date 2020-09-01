using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using NBut.Workflow.Activities.Design.Designers;
using NBut.Workflow.Activities.Design.Properties;

namespace NBut.Workflow.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            #region Setup

            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            #endregion Setup


            builder.AddCustomAttributes(typeof(IfThen), categoryAttribute);
            builder.AddCustomAttributes(typeof(IfThen), new DesignerAttribute(typeof(IfThenDesigner)));
            builder.AddCustomAttributes(typeof(IfThen), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
