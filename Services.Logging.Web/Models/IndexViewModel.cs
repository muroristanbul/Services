namespace Services.Logging.Web.Models
{
    public class IndexViewModel
    {
        public ProjectFormModel ProjectFormModel { get; set; }

        public string Token { get; set; }
    }

    public class ProjectFormModel
    {
        public string ProjectName { get; set; }
    }

    public class PersonModel
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}