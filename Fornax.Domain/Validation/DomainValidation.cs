namespace Fornax.Domain.Validation
{
    public class DomainValidation : Exception
	{
		public DomainValidation(string error) : base(error)
		{
		}

		public static void Validate(bool hasError, string error)
		{
			if (hasError) throw new DomainValidation(error);
		}
	}
}

