namespace Skeleton;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class CategoryAttribute : Attribute
{
    public CategoryAttribute(string name)
    {

    }
}
