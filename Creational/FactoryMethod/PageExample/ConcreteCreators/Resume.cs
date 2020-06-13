namespace FactoryMethod
{
    /// <summary>
    /// Overrides the "Factory Method" to return an instance of a "Concrete Product".
    /// </summary>
    public class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
