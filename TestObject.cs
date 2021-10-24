namespace ReproChildPropsCSVHelper
{
    class TestObject
    {
        [CsvHelper.Configuration.Attributes.Name("attribute_first")]
        public Microsoft.Xrm.Sdk.EntityReference attribute_first { get; set; }

        [CsvHelper.Configuration.Attributes.Name("attribute_second")]
        public Microsoft.Xrm.Sdk.EntityReference attribute_second { get; set; }
    }
}
