using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;

public class EFStatus
{
 
    private List<ValidationResult> _errors;
 
    /// <summary>
    /// If there are no errors then it is valid
    /// </summary>
    public bool IsValid { get { return _errors == null; } }
 
    public IReadOnlyList<ValidationResult> EfErrors
    {
        get { return _errors ?? new List<ValidationResult>(); }
    }
 
    /// <summary>
    /// This converts the Entity framework errors into Validation errors
    /// </summary>
    public EFStatus SetErrors(IEnumerable<DbEntityValidationResult> errors)
    {
        _errors =
            errors.SelectMany(
                x => x.ValidationErrors.Select(y => 
	                      new ValidationResult(y.ErrorMessage, new[] {y.PropertyName})))
                .ToList();

            return this;
	    }

	    public  EFStatus SetErrors(IEnumerable<ValidationResult> errors)
	    {
	        _errors = errors.ToList();
	         return this;
	    }
 
}