namespace Open.Cloneable
{

	public interface ICloneable
	{
		object Clone();
	}

	public interface ICloneable<out T> : ICloneable
	{
		new T Clone();
	}

}
